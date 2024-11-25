using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverMenu; // Asigna el Canvas del men� de Game Over en el Inspector.

    public void GameOver()
    {
        gameOverMenu.SetActive(true); // Activa el men� de Game Over.
        Time.timeScale = 0f; // Detiene el tiempo del juego.
    }

    public void Retry()
    {
        Time.timeScale = 1f; // Restaura el tiempo normal.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Reinicia la escena actual.
    }

    public void Exit()
    {
        Time.timeScale = 1f; // Aseg�rate de restaurar el tiempo antes de salir.
        Application.Quit();
        Debug.Log("Juego cerrado."); // Este mensaje solo se ver� en el editor.
    }
}
