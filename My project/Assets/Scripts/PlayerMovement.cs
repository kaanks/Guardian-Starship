using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody pysic;
    float horizontal = 0;
    float vertical = 0;
    public float movementSpeed;
    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;
    public float slope;


    Vector3 vec;
    void Start()
    {
        pysic = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        horizontal = Input.GetAxis(("Horizontal"));
        vertical = Input.GetAxis("Vertical");
        vec = new Vector3(horizontal, 0, vertical);

        pysic.velocity = vec * movementSpeed;

        pysic.position = new Vector3
        (
            Mathf.Clamp(pysic.position.x,minX,maxX), 0.0f,Mathf.Clamp(pysic.position.z,minZ,maxZ)
        );

        pysic.rotation = Quaternion.Euler(90, 0, pysic.velocity.x * -slope);


    }
}
