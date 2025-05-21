using UnityEngine;

public class PlayerCollisionSounds : MonoBehaviour
{
    public AudioSource fxAudioSource;      // AudioSource para efectos (splash, choque, victoria)
    public AudioSource motorAudioSource;   // AudioSource del motor

    public AudioClip splashSound;
    public AudioClip crashSound;
    public AudioClip winSound;

    private void OnCollisionEnter ( Collision collision )
    {
        if (collision.gameObject.CompareTag("Obstaculo"))
        {
            if (fxAudioSource != null && crashSound != null)
                fxAudioSource.PlayOneShot(crashSound);

            if (motorAudioSource != null)
                motorAudioSource.Stop(); // Detiene el motor al chocar
        }
    }

    private void OnTriggerEnter ( Collider other )
    {
        if (other.CompareTag("Agua"))
        {
            if (fxAudioSource != null && splashSound != null)
                fxAudioSource.PlayOneShot(splashSound);

            if (motorAudioSource != null)
                motorAudioSource.Stop(); // Detiene el motor al caer al agua
        }

        if (other.CompareTag("Victoria"))
        {
            if (fxAudioSource != null && winSound != null)
                fxAudioSource.PlayOneShot(winSound);

            if (motorAudioSource != null)
                motorAudioSource.Stop(); // Detiene el motor al ganar
        }
    }
}
