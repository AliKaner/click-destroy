using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManageScript : MonoBehaviour
{
    [SerializeField]
    int score = 0;
    [SerializeField]
    Text scoreText;
    [SerializeField]
    Text lwlText;

    public GameObject clone;
    public float levelMultiplier = 1f;
    public float spawnTime = 400f;
    int Tcount = 0;
    int lwl = 1;
    public void IncreaseScore()
    {
        score += 1;
        scoreText.text = "Score:" + score;
        IncreaseLwl();
    }
    public void IncreaseLwl()
    {
        lwlText.text = "LEVEL " + (lwl+ ((score/10)));
    }
    public void ObjDisplay(GameObject game)
    {
        Vector2 randomPosition = new Vector2(Random.Range(-9.5f, 9.5f), Random.Range(4f, -4f)); // sonra bak  

        GameObject wordObj = Instantiate(game, randomPosition,transform.rotation);
    }
    private void Update()
    {
       
            Tcount++;
        spawnTime = spawnTime*levelMultiplier;
        if (Tcount > spawnTime)
        {
            ObjDisplay(clone);
            Tcount = 0;
        }
    }
}
