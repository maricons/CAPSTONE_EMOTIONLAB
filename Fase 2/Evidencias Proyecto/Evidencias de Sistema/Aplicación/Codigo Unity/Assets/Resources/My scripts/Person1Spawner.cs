using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person1Spawner : MonoBehaviour
{
    public GameObject[] personPrefabs; // Prefab de la persona

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPerson", 0f, 7f);
    }

    public void SpawnPerson()
    {
        int randomIndex = Random.Range(0, personPrefabs.Length);
        Instantiate(personPrefabs[randomIndex], transform.position, transform.rotation);

    }

}
