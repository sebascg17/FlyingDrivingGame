using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 0.5f;
    public float rotationSpeed = 25f;
    public float verticalInput;

    private Rigidbody rb;
    private bool haColisionado = false;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        rb.isKinematic = true; // Movimiento manual al principio
    }

    void FixedUpdate ()
    {
        if (haColisionado) return;

        verticalInput = Input.GetAxis("Vertical");

        // Movimiento manual
        transform.Translate(Vector3.forward * speed);
        transform.Rotate(Vector3.right * verticalInput * rotationSpeed * Time.deltaTime);
    }

    void OnCollisionEnter ( Collision collision )
    {

        haColisionado = true;

        // Activar la física real
        rb.isKinematic = false;
        rb.useGravity = true;

        // Opcional: quitar control del jugador
        // this.enabled = false;
    }
}
