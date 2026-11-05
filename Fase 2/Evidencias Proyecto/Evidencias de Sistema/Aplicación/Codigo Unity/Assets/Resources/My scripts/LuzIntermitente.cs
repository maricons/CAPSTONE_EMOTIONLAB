using System.Collections;
using UnityEngine;

public class LuzIntermitente : MonoBehaviour
{
    public Light luz;
    public float intervalo = 0.8f;
    private bool parpadeando = false;

    public void IniciarParpadeo()
    {
        if (!parpadeando)
        {
            parpadeando = true;
            StartCoroutine(Parpadear());
        }
    }

    IEnumerator Parpadear()
    {
        while (parpadeando)
        {
            Debug.Log("Se activa parpadeo");
            luz.intensity = (luz.intensity == 0) ? 5f : 0f;
            yield return new WaitForSeconds(intervalo);
        }
    }

    public void DetenerParpadeo()
    {
        Debug.Log("Se detiene parpadeo");
        parpadeando = false;
        luz.intensity = 5f; // Asegurarse de que la luz esté encendida
    }
}