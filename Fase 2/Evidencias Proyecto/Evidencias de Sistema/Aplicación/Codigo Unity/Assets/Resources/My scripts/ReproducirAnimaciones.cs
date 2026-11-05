using UnityEngine;
using System.Collections;

public class ReproducirAnimaciones : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Enable to play animations automatically")]
    public bool autoPlayAnimations = true;

    [SerializeField]
    [Tooltip("Minimum time between animations (seconds)")]
    public float minTimeBetweenAnimations = 5f;

    [SerializeField]
    [Tooltip("Maximum time between animations (seconds)")]
    public float maxTimeBetweenAnimations = 10f;

    [SerializeField]
    [Tooltip("Escribe AQUÍ los nombres EXACTOS de los estados del Animator")]
    private string[] animationStateNames; //

    private Animator animator;


    void Start()
    {
        animator = GetComponent<Animator>();
        
        if (animator != null && autoPlayAnimations)
        {
            animator.Update(0f);
            // ¡Ahora revisamos la lista de NOMBRES, no de clips!
            if (animationStateNames.Length > 0)
            {
                PlayRandomAnimation();
                StartCoroutine(PlayAnimationsLoop());
            }
            else
            {
                Debug.LogWarning("La lista 'Animation State Names' está vacía en el Inspector.");
            }
        }
    }

    // Reproduce una animación aleatoria
    private void PlayRandomAnimation()
    {
        string randomStateName = animationStateNames[Random.Range(0, animationStateNames.Length)];
        int layerIndex = 0;
        animator.CrossFadeInFixedTime(randomStateName, 0.3f, layerIndex);
    }

    // Bucle infinito para cambiar animaciones
    private IEnumerator PlayAnimationsLoop()
    {
        while (true)
        {
            float waitTime = Random.Range(minTimeBetweenAnimations, maxTimeBetweenAnimations);
            yield return new WaitForSeconds(waitTime);
            PlayRandomAnimation();
        }
    }
}