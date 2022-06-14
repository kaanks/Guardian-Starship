using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntitySouls : MonoBehaviour
{
    public GameObject explode;
    public GameObject playerExplode;
    private GameObject gameControl;
     private GameManager control;

    private void Start()
    {
        gameControl = GameObject.FindGameObjectWithTag("GameControl");
        control = gameControl.GetComponent<GameManager>();
        


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag!=("LimitLane"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            Instantiate(explode, transform.position, transform.rotation);
            control.ScoreCount(10);
        }

        if (other.tag=="Player")
        {
            Instantiate(playerExplode, other.transform.position, other.transform.rotation);
        }
      
    }
}
