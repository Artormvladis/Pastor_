using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyStateManager : MonoBehaviour
{
    [SerializeField] NavMeshAgent navMeshAgent;
    [SerializeField] Transform player;
    [SerializeField] public Animator animator;
    [SerializeField] public int HP;
    Transform target;
    BaseState currentState;
    public AgroState agroState = new AgroState();
    public AttacState attacState = new AttacState();
    public PoiskState poiskState = new PoiskState();
    public IdleState idleState = new IdleState();
    public Death death = new Death();

    public void SwitchState(BaseState newState)
    {
        if (currentState != null)
        {
            currentState.ExitState(this);
        }
        currentState = newState;
        currentState.EnterState(this);
    }
    private void Start()
    {
        SwitchState(idleState);
    }
    private void Update()
    {
        SetDestination(player);
        navMeshAgent.destination = target.position;
        currentState.UpdateState(this);
    }
    public void SetSpeed(float newSpeed)
    {
        navMeshAgent.speed = newSpeed;
    }
    public void SetDestination(Transform newDestination)
    {
        target = newDestination;
    }
    public float DistToTarget()
    {
        return (transform.position - target.transform.position).magnitude;
    }
    public void Attackstop()
    {
        if (DistToTarget() > 1.7)
        {
            SwitchState(agroState);
            return;
        }
        if (DistToTarget() < 1.7)
        {
            SceneManager.LoadSceneAsync("Main menu");
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (HP > 0)
        {
            HP -= 1;
        }
        else
        {
            SwitchState(death);
        }
    }
}
