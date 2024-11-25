using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverMenu; // Menú de Game Over.

    public void GameOver()
    {
        Debug.Log("Game Over activado");
        Time.timeScale = 0; // Pausar el juego.
        gameOverMenu.SetActive(true); // Mostrar el menú de Game Over.
    }

    public void Retry()
    {
        Debug.Log("Retry presionado");
        Time.timeScale = 1; // Restablecer la escala de tiempo.
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reinicia la escena actual.
    }

    public void Exit()
    {
        Debug.Log("Exit presionado"); // Mostrar mensaje en la consola para depuración.
        Application.Quit(); // Cierra la aplicación.
    }
}
