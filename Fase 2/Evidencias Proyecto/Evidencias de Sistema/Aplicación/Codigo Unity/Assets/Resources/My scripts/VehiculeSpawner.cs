using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehiculeSpawner : MonoBehaviour
{
    public GameObject[] vehiculesPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnVehicule", 0f, 6f);
    }

    public void SpawnVehicule()
    {
        if (vehiculesPrefabs == null)
        {
            Debug.LogError("vehiculesPrefabs es null");
            return;
        }
        if (vehiculesPrefabs.Length == 0)
        {
            Debug.LogError("vehiculesPrefabs está vacío");
            return;
        }

        for (int i = 0; i < vehiculesPrefabs.Length; i++)
        {
            if (vehiculesPrefabs[i] == null)
                Debug.LogError("Prefab en índice " + i + " es null");
        }

        int randomIndex = Random.Range(0, vehiculesPrefabs.Length);
        if (vehiculesPrefabs[randomIndex] == null)
        {
            Debug.LogError("El prefab seleccionado es null");
            return;
        }

        Instantiate(vehiculesPrefabs[randomIndex], transform.position, transform.rotation);
    }

}
