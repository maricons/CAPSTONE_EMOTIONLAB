using System.Collections;
using UnityEngine;
using TMPro; // <- necesario para usar TextMeshPro

[RequireComponent(typeof(AudioSource))]
public class ArreglarGenerador : MonoBehaviour
{
    public Interrupciones interrupciones;
    public float tiempoReparacion = 5f;
    private float tiempoEnTrigger = 0f;
    private bool enReparacion = false;
    private Coroutine reparacionCoroutine;
    private bool generadorYaReparado = false;
    private AudioSource audioReparacion;


    [Header("UI de Reparación")]
    public GameObject textoReparando; // <- arrastrar aquí el texto desde el inspector

    private void Start()
    {
        // Obtenemos el AudioSource que está en este mismo objeto
        audioReparacion = GetComponent<AudioSource>();
        // Aseguramos que el texto esté oculto al inicio
        if (textoReparando != null)
            textoReparando.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Añade la comprobación de si ya fue reparado
        if (other.CompareTag("ControladorVR") && !generadorYaReparado)
        {
            if (!enReparacion)
            {
                enReparacion = true;
                // 1. Ocultamos la notificación general (llamando al cerebro)
                if (interrupciones != null)
                {
                    interrupciones.OcultarNotificacion();
                }
                
                // 2. Mostramos el texto específico de "Reparando"
                if (textoReparando != null)
                    textoReparando.SetActive(true);
                if (textoReparando != null)
                    textoReparando.SetActive(true); // <- mostrar mensaje
                if (audioReparacion != null)
                    audioReparacion.Play();
                reparacionCoroutine = StartCoroutine(RepararGenerador());
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("ControladorVR"))
        {
            enReparacion = false;
            tiempoEnTrigger = 0f;
            if (reparacionCoroutine != null)
                StopCoroutine(reparacionCoroutine);
            if (audioReparacion != null && !generadorYaReparado)
                audioReparacion.Stop();
            if (textoReparando != null)
                textoReparando.SetActive(false); // <- ocultar mensaje
            // Si el jugador sale SIN haber reparado, 
            // volvemos a mostrar la notificación general.
            if (interrupciones != null && !generadorYaReparado)
            {
                interrupciones.MostrarNotificacion();
            }
        }
    }

    private IEnumerator RepararGenerador()
    {
        tiempoEnTrigger = 0f;
        while (tiempoEnTrigger < tiempoReparacion)
        {
            if (!enReparacion)
                yield break;

            tiempoEnTrigger += Time.deltaTime;
            yield return null;
        }

        // Reparación completada
        if (textoReparando != null)
            textoReparando.SetActive(false);

        if (interrupciones == null)
        {
            Debug.LogError("La referencia a 'interrupciones' es null.");
            yield break;
        }

        interrupciones.TerminarInterrupcionGenerador();
        generadorYaReparado = true; // <- ¡Activamos la "memoria"!
        if (audioReparacion != null)
            audioReparacion.Stop();
    }
}