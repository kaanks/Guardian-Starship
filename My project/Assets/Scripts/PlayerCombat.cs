using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    
    private float fireTime = 0;
    public float fireTimeSec;
    public GameObject lazer;
    public Transform lazerTransform1;
    public Transform lazerTransform2;
    private new AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton(("Fire1"))&& Time.time>fireTime )
        {
            fireTime = Time.time + fireTimeSec;
            Instantiate(lazer, lazerTransform1.position, quaternion.identity);
            Instantiate(lazer, lazerTransform2.position, quaternion.identity);
            audio.Play();
           
        }
       
    }

    
}
