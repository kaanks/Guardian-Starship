using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public GameObject asteroid;
    public int dorpAsteroid;
    public float dropAsteroidSec;
    public float returnSec;
    public float startAsteroidSec;
    public Text text;

    private int gameScore;
    //public Vector3 randomPos;
    void Start()
    {
        gameScore = 0;
        text.text = "score=" + gameScore;
        
        StartCoroutine(create());

    }

    IEnumerator create()
    {
        yield return new WaitForSecondsRealtime(startAsteroidSec);
        while (true)
        {
            for (int i = 0; i < dorpAsteroid; i++)
            {
                        var position = new Vector3(Random.Range(-6.5f, 6.5f), 0, 14.5f);
                        Instantiate(asteroid, position, Quaternion.identity);
                        yield return new WaitForSecondsRealtime(dropAsteroidSec);
            }
            yield return new WaitForSecondsRealtime(returnSec);
        }
        
    }

    public void ScoreCount(int lastScore)
    {
        gameScore += lastScore;
        text.text = "score=" + gameScore;
        
    }
    
}
