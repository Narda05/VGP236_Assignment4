using UnityEngine;

public class PlayerSnowballThrower : MonoBehaviour
{
    public GameObject snowballPrefab; // Prefab de la bola de nieve
    public Transform throwPoint; // Punto desde donde se lanzará
    public float throwForce = 10f;
    public bool canThrow = false; // Solo puede lanzar después de tocar el EndPoint

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