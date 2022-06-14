using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    private Rigidbody physic;
    public float rotationSpeed;
    private Rigidbody astero;
    public float asteroidSpeed;
    void Start()
    {
        physic = GetComponent<Rigidbody>();
        physic.angularVelocity = Random.insideUnitSphere * rotationSpeed;
        astero = GetComponent<Rigidbody>();
        astero.velocity = transform.forward * -asteroidSpeed;
    }
   
   
    // Update is called once per frame
    void Update()
    {
        
    }
}
