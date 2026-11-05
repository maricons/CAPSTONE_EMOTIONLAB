using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class CargarPresentacion : MonoBehaviour
{
    public Image slideDisplay; // Asigna el componente Image desde el Inspector
    private Sprite[] slides;
    private int currentIndex = 0;

    void Start()
    {
        string nombrePresentacion = PlayerPrefs.GetString("PresentacionSeleccionada", "");

        if (string.IsNullOrEmpty(nombrePresentacion))
        {
            Debug.LogError("No se seleccionó ninguna presentación.");
            return;
        }

        // Cargar todos los slides desde Resources
        slides = Resources.LoadAll<Sprite>("imagenes/" + nombrePresentacion);

        // Ordenar los slides por nombre
        slides = slides.OrderBy(s => s.name).ToArray();

        if (slides.Length == 0)
        {
            Debug.LogError("No se encontraron slides para la presentación: " + nombrePresentacion);
            return;
        }

        currentIndex = 0;
        MostrarSlideActual();
    }

    public void SiguienteSlide()
    {
        if (currentIndex == slides.Length - 1)
        {
            MostrarSlideActual();

        }
        else
        {
            currentIndex ++;
            MostrarSlideActual();
        }
        
    }

    public void AnteriorSlide()
    {
        if (currentIndex == 0)
        {
            MostrarSlideActual();
        }
        else
        {
            currentIndex --;
            MostrarSlideActual();
        }
    }

    private void MostrarSlideActual()
    {
        slideDisplay.sprite = slides[currentIndex];
    }
}
