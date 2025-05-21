using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(50f, 5f, 0f); // Posición relativa a la derecha y ligeramente arriba
    public Vector3 angulo = new Vector3(0f, 90f, 0f); // Rotación tipo 2.5D

    void Start ()
    {
        // Rotación inicial de la cámara para vista lateral tipo 2.5D
        transform.rotation = Quaternion.Euler(angulo);
    }

    void LateUpdate ()
    {
        if (player == null) return;

        // Sigue al jugador aplicando el offset completo, incluyendo altura
        transform.position = player.transform.position + offset;
    }
}
