using UnityEngine;

public class GameOverTrigger : MonoBehaviour
{
    public GameOverManager gameOverManager; 

    private bool canTrigger = false;

    private void Start ()
    {
        // Evitar que se active el trigger justo al inicio por si el avión está dentro
        StartCoroutine(EnableTriggerAfterDelay());
    }

    private System.Collections.IEnumerator EnableTriggerAfterDelay ()
    {
        yield return new WaitForSeconds(1f);  // Espera 1 segundo para activar triggers
        canTrigger = true;
    }

    private void OnTriggerEnter ( Collider other )
    {
        if (!canTrigger) return;

        if (other.CompareTag("Player"))
        {
            Debug.Log("Avión tocó el agua - Game Over");
            gameOverManager.TriggerGameOver();
        }
    }
}
