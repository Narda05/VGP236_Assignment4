using UnityEngine;

public class PlayerSnowballThrower : MonoBehaviour
{
    public GameObject snowballPrefab;
    public Transform throwPoint; 
    public float throwForce = 10f;
    public bool canThrow = false; 

    void Start()
    {
        canThrow = false;
    }
    void Update()
    {
        if (canThrow && Input.GetKeyDown(KeyCode.E)) // Presiona Espacio para lanzar
        {
            ThrowSnowball();
        }
    }

    void ThrowSnowball()
    {
        GameObject snowball = Instantiate(snowballPrefab, throwPoint.position, throwPoint.rotation);
        Rigidbody rb = snowball.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * throwForce, ForceMode.Impulse);
    }
}