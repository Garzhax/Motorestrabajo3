using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject youWinCanvas; // Referencia al Canvas de "YOU WIN"

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject); // Destruye al enemigo
            ShowYouWin();        // Muestra el cartel de "YOU WIN"
        }
    }

    void ShowYouWin()
    {
        youWinCanvas.SetActive(true); // Activa el Canvas
    }
}
