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
    bool attacked = false;

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
        if (DistToTarget() > 1.7 + HP)
        {
            SwitchState(agroState);
            return;
        }
        if (DistToTarget() < 1.7 + HP)
        {
            SceneManager.LoadSceneAsync("Lose");
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            HP = 0;
            SwitchState(death);
            Win.score += 1000;
        }
        else if (HP == 0 && attacked)
        {
            SwitchState(death);
        }
        else if (attacked)
        {
            HP -= 1;
        }
        attacked = false;
    }
    public void OnTriggerExit(Collider other)
    {
        attacked = true;
    }
}
