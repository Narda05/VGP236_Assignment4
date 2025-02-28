using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class AIRandomPoints : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public float wanderRadius = 15f;  
    public float wanderDelay = 3f;    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(WanderRoutine());
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    IEnumerator WanderRoutine()
    {
        while (true)
        {
            Vector3 newDestination = GetRandomPoint(transform.position, wanderRadius);
            navMeshAgent.SetDestination(newDestination);
            yield return new WaitForSeconds(wanderDelay); 
        }
    }
    Vector3 GetRandomPoint(Vector3 origin, float radius)
    {
        Vector3 randomDirection = Random.insideUnitSphere * radius; 
        randomDirection += origin; 
        NavMeshHit hit;

        if (NavMesh.SamplePosition(randomDirection, out hit, radius, NavMesh.AllAreas))
        {
            return hit.position; 
        }
        return origin; 
    }
}

