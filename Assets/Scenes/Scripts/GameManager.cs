using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    int score;
    [SerializeField]
    Text scoreText;

    public GameObject clickableObjectDummy;
    int spawnCounter;

    public void IncreaseScore()
    {
        score += 1;
        scoreText.text = "Score: " + score;
    }

    private void Update()
    {
        spawnCounter++;

        if(spawnCounter > 100)
        {
            Instantiate(clickableObjectDummy, new Vector2(Random.Range(-6,6), Random.Range(-4,4)), transform.rotation);
            spawnCounter = 0;
        }
    }
}
