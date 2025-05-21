using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Variables privadas para el movimiento del vehiculo
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float forwardInput;
    private float horizontalInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Recibir input del jugador
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        //Mover vehiculo al frente
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Girar vehiculo
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
