using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerController : MonoBehaviour
{
    private Rigidbody pysic;
    public float lazerSpeed;
    void Start()
    {
        pysic = GetComponent<Rigidbody>();
        pysic.velocity = transform.forward * lazerSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
