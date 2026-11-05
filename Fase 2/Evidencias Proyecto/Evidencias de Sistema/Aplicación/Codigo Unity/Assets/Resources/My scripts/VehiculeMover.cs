using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehiculeMover : MonoBehaviour
{
    private float speed = 6f; // Velocidad de movimiento del vehículo

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
