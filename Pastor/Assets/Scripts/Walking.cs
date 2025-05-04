using UnityEngine;
using UnityEngine.AI;

public class Walking : MonoBehaviour
{
    [SerializeField] NavMeshAgent navMeshAgent;
    [SerializeField] Transform player;
    private void Update()
    {
        navMeshAgent.destination = player.position;
    }
}
