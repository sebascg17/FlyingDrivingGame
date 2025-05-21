using UnityEngine;

public class GirarHelice : MonoBehaviour
{
    private float velocidadRotacion = 1000f; // grados por segundo

    void Update ()
    {
        // Rotar en el eje Z
        transform.Rotate(0f, 0f, velocidadRotacion * Time.deltaTime);
    }
}
