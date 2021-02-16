using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    Vector2 newSize;
    public float reduceAmount = 0.01f;
    GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.FindWithTag("GameController").GetComponent<GameManager>();
    }

    private void Update()
    {
        if(transform.localScale.x > 0.1)
        {
            newSize.x = transform.localScale.x - reduceAmount; 
            newSize.y = transform.localScale.y - reduceAmount;

            transform.localScale = newSize;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnMouseDown()
    {
        gameManager.IncreaseScore();
        Destroy(gameObject);
    }
}
