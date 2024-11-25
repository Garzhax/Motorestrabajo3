using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject winText; // Referencia al texto de victoria

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject); // Destruye al enemigo

            // Mostrar el texto de victoria
            winText.SetActive(true);
        }
    }
}
