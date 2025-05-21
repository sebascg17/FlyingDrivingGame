using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverPanel;

    void Start ()
    {
        gameOverPanel.SetActive(false);  // Se oculta al iniciar
    }

    public void TriggerGameOver ()
    {
        gameOverPanel.SetActive(true);  // Se muestra al colisionar
        Time.timeScale = 0f;             // Pausa el juego
    }

    public void Retry ()
    {
        Time.timeScale = 1f; // Reanuda el tiempo
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Reinicia la escena
    }
}
