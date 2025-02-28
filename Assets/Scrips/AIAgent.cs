using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AIAgent : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Transform chaseTarget;

    public List<Transform> waypoints;
    private int currentWaypoint = 0;

    private AIState aiState;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        navMeshAgent.SetDestination(waypoints[currentWaypoint].position);
        aiState = AIState.Wander;
    }

    // Update is called once per frame
    void Update()
    {
        if (aiState == AIState.Wander)
        {

            if (navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance)
            {
                currentWaypoint = (currentWaypoint + 1) % waypoints.Count;
                navMeshAgent.SetDestination(waypoints[currentWaypoint].position);
            }
        }
        else if (aiState == AIState.Chase)
        {
            navMeshAgent.SetDestination(chaseTarget.position);

            if (Vector3.Distance(transform.position, chaseTarget.position) > 15)
            {
                aiState = AIState.Wander;
                navMeshAgent.SetDestination(waypoints[currentWaypoint].position);
            }

        }
    }
    public void HostileSpotted(Transform hostileTarget)
    {
        chaseTarget = hostileTarget;
        aiState = AIState.Chase;
        navMeshAgent.SetDestination(chaseTarget.position);
        
    }
}
    public enum AIState
    {
        Wander,
        Chase
    }

 
