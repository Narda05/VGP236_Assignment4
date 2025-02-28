using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealt : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("The lion kill you");
            Die();
        }
    }
    void Die()
    {
        Debug.Log("The player is dead. Reload game");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
