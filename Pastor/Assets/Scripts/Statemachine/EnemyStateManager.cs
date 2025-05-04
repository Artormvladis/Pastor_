using UnityEngine;
using UnityEngine.AI;

public class EnemyStateManager : MonoBehaviour
{
    [SerializeField] NavMeshAgent navMeshAgent;
    [SerializeField] Transform player;
    Transform target;
    BaseState currentState;
    public AgroState agroState = new AgroState();
    public AttacState attacState = new AttacState();
    public PoiskState poiskState = new PoiskState();
    public IdleState idleState = new IdleState();

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
}
