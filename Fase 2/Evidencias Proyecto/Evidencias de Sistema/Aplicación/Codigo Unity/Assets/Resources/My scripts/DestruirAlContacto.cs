using UnityEngine;

public class DestruirAlContacto : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Person"))
        {
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Vehicule"))
        {
            Destroy(other.gameObject);
        }
    }
}