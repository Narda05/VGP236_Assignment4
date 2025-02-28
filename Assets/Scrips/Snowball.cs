using UnityEngine;

public class Snowball : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy")) // Si golpea a un enemigo
        {
            Destroy(collision.gameObject); // Destruye al enemigo
            Destroy(gameObject); // Destruye la bola de nieve también
        }
    }
}