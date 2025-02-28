using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public Transform startPoint;
    public Transform endPoint;

    private void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Hostile");
        if (player != null)
        {
            player.transform.position = startPoint.position;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hostile"))
        {
            GiveSnowballPower(other.gameObject);
        }
    }

    void GiveSnowballPower(GameObject player)
    {
        Debug.Log("¡Power ractive!");
        PlayerSnowballThrower thrower = player.GetComponent<PlayerSnowballThrower>();
        if (thrower != null)
        {
            thrower.canThrow = true; // Activa la habilidad de lanzar bolas de nieve
            endPoint.gameObject.SetActive(false);
        }
    }
}