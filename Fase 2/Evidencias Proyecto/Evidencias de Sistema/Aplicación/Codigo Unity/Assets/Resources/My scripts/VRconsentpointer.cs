using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.UI;

/// <summary>
/// Configura la interacción entre los controles VR y el UI del consentimiento.
/// 
/// REQUISITO: Necesitas el paquete "XR Interaction Toolkit" instalado.
/// Si usas otro sistema VR (SteamVR, Oculus SDK), ajusta según corresponda.
/// 
/// Adjunta este script al GameObject de tu cámara VR o al EventSystem.
/// </summary>
public class VRConsentPointer : MonoBehaviour
{
    [Header("Referencia al Ray Interactor del control")]
    [Tooltip("El XRRayInteractor del controlador derecho (o el que uses para UI)")]
    public XRRayInteractor rightHandRayInteractor;

    [Tooltip("El XRRayInteractor del controlador izquierdo (opcional)")]
    public XRRayInteractor leftHandRayInteractor;

    [Header("Visual del puntero")]
    [Tooltip("Línea visual del rayo (Line Renderer en el controlador)")]
    public LineRenderer pointerLineRenderer;

    [Header("Configuración")]
    [Tooltip("Color del rayo cuando apunta a UI interactuable")]
    public Color rayActiveColor = new Color(0.2f, 0.6f, 1f);

    [Tooltip("Color del rayo en estado normal")]
    public Color rayNormalColor = new Color(1f, 1f, 1f, 0.5f);

    void Start()
    {
        // Asegurarse de que el EventSystem tenga el componente para UI de XR
        EnsureXRUIInputModule();
    }

    void EnsureXRUIInputModule()
    {
        EventSystem eventSystem = FindObjectOfType<EventSystem>();
        if (eventSystem == null)
        {
            Debug.LogWarning("[VRConsentPointer] No se encontró EventSystem en la escena. " +
                           "Crea un GameObject con EventSystem y XRUIInputModule.");
            return;
        }

        // Verificar si ya tiene XRUIInputModule
        XRUIInputModule xrInput = eventSystem.GetComponent<XRUIInputModule>();
        if (xrInput == null)
        {
            // Remover el StandaloneInputModule si existe (conflicto con XR)
            StandaloneInputModule standaloneModule = eventSystem.GetComponent<StandaloneInputModule>();
            if (standaloneModule != null)
                Destroy(standaloneModule);

            // Agregar el módulo de input para XR
            eventSystem.gameObject.AddComponent<XRUIInputModule>();
            Debug.Log("[VRConsentPointer] XRUIInputModule agregado al EventSystem.");
        }
    }

    void Update()
    {
        UpdateRayColor();
    }

    void UpdateRayColor()
    {
        if (pointerLineRenderer == null || rightHandRayInteractor == null) return;

        // Cambiar color del rayo según si está sobre UI
        bool isOverUI = rightHandRayInteractor.TryGetCurrentUIRaycastResult(out RaycastResult result);
        Color targetColor = isOverUI ? rayActiveColor : rayNormalColor;

        pointerLineRenderer.startColor = targetColor;
        pointerLineRenderer.endColor = new Color(targetColor.r, targetColor.g, targetColor.b, 0f);
    }
}