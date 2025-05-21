using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverPanel;

    void Start ()
    {
        gameOverPanel.SetActive(false);  // Se oculta al iniciar
        Time.timeScale = 1f;
    }

    public void TriggerGameOver ()
    {
        gameOverPanel.SetActive(true);  // Se muestra al colisionar
        Time.timeScale = 1f; 

        // Pausa el juego después de un momento para que suene el audio
        StartCoroutine(PausarLuegoDeSonar());
    }    

    IEnumerator PausarLuegoDeSonar ()
    {
        yield return new WaitForSeconds(1f); // Espera 1 segundo para que suene el audio
        Time.timeScale = 0f;
    }

    public void Retry ()
    {
        Time.timeScale = 1f; // Reanuda el tiempo
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Reinicia la escena
    }
}
