using UnityEngine;
using UnityEngine.AI;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Transform destinationMainCharacter;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        navMeshAgent.SetDestination(destinationMainCharacter.position);
    }
}
