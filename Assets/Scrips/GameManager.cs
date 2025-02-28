using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; } 
    public GameObject winMessage; 
    public int totalEnemies; 

    private int enemiesKilled = 0; 

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        winMessage.SetActive(false); 
    }

    
    public void EnemyKilled(GameObject enemy)
    {
        enemiesKilled++;

       
        if (enemiesKilled >= totalEnemies)
        {
            Debug.Log("¡Enemis gone!");
            winMessage.SetActive(true); 
        }
    }
}
