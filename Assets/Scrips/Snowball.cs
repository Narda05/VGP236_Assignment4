using Unity.VisualScripting;
using UnityEngine;

public class Snowball : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy")) // Si golpea a un enemigo
        {
            Destroy(collision.gameObject); // Destruye al enemigo
            Destroy(gameObject); // Destruye la bola de nieve también
            // send event that enemy is dead
            // GameManager.Instance.AddEnemyScore();
            // GameManager => total enemies to kill
            // 2 options:
            //  1) count all (or manually tell GameManger how many enemies to kill)
            //  2) everytime something is kill, in GameManager go to each enemy folder/list LionsAttack.childCount == 0 (safety check, go through all lions and check if they are dead)
            // if(gameObject.IsDestroyed()) do not count
        }
    }
}