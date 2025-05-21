using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGameManager : MonoBehaviour
{
    public GameObject winPanel;

    void Start ()
    {
        winPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    private void OnTriggerEnter ( Collider other )
    {
        if (other.CompareTag("Player"))
        {
            ShowWinPanel();
        }
    }

    void ShowWinPanel ()
    {

        // Activa la pantalla de victoria
        winPanel.SetActive(true);

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
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Quit ()
    {
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
