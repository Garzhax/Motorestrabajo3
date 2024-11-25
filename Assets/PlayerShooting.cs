using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab; // Referencia al prefab del proyectil
    public Transform firePoint; // Punto desde donde se disparará el proyectil
    public float bulletSpeed = 10f; // Velocidad del proyectil

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // Detecta clic izquierdo
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Instanciar el proyectil en el punto de disparo
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = bullet.AddComponent<Rigidbody>(); // Agregar Rigidbody para movimiento
        rb.useGravity = false; // Desactiva la gravedad
        rb.velocity = firePoint.forward * bulletSpeed; // Mueve el proyectil hacia adelante

        // Destruir el proyectil después de 3 segundos
        Destroy(bullet, 3f);
    }
}
