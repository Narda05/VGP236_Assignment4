using UnityEngine;

public class AISight : MonoBehaviour
{
    public AIAgent agent;
    public Transform eyes;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerStay(Collider other)
    {
        
        //first check; did i get you im my trigger box?
        if (other.tag == "Hostile")
        {
            //second checl; Is there no obstruction in my sight?
            RaycastHit hit;
            if (Physics.Linecast(eyes.position, other.transform.position, out hit))
            {
                //Somthing obstructed my view
                //Special tipy o dibug 
                //is the esact point to the obstruction hit.point
                Debug.DrawLine(eyes.position, hit.point, Color.blue, 1f);
                if(hit.transform.tag == "Hostile")
                {
                    //Hostile found!
                    Debug.DrawLine(eyes.position,other.transform.position, Color.red, 1f);
                    agent.HostileSpotted(other.transform);
                }
            }
            else
            {
                //No obstruction. Hostile  found!
                Debug.DrawLine(eyes.position, other.transform.position, Color.red, 1f);
                agent.HostileSpotted(other.transform);

            }
        }
    }
}
