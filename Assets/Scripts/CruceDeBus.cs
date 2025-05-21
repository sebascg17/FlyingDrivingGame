using System.Collections;
using UnityEngine;

public class CruceDeBus : MonoBehaviour
{
    public Transform puntoA;
    public Transform puntoB;
    public float velocidad = 2f;
    public float tiempoEspera = 0.5f;

    private void Start ()
    {
        StartCoroutine(MoverEntrePuntos());
    }

    IEnumerator MoverEntrePuntos ()
    {
        while (true)
        {
            // Ir de A a B
            yield return StartCoroutine(MoverHacia(puntoB));
            yield return new WaitForSeconds(tiempoEspera);
            RotarObstaculo();

            // Ir de B a A
            yield return StartCoroutine(MoverHacia(puntoA));
            yield return new WaitForSeconds(tiempoEspera);
            RotarObstaculo();
        }
    }

    IEnumerator MoverHacia ( Transform destino )
    {
        while (Vector3.Distance(transform.position, destino.position) > 0.01f)
        {
            transform.position = Vector3.MoveTowards(transform.position, destino.position, velocidad * Time.deltaTime);
            yield return null;
        }
        transform.position = destino.position;
    }

    void RotarObstaculo ()
    {
        transform.Rotate(Vector3.up * 180); // Rota 180 grados sobre el eje Z (ajusta si es en otro eje)
    }
}
