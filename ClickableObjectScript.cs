using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableObjectScript : MonoBehaviour
{
    Vector2 newSize;
    public float x_axisChanger = 3;
    public float y_axisChanger = 3;
    public float decreaseRate;
    public float sizeDeadline;
    public Sprite spriteDestroy;
    GameManageScript gameManageScript;

    
    public void SelfDestroy()
    {
        Destroy(gameObject);
    }
    public void GettingDestroyed()
    {
        Destroy(gameObject);
        gameManageScript.IncreaseScore();

    }
    private void Start()
    {
        gameManageScript = GameObject.FindWithTag("GameController").GetComponent<GameManageScript>();
    }
    private void GettingSmaller()
    {
        gameObject.GetComponent<Transform>().localScale = new Vector2(x_axisChanger, y_axisChanger);
        x_axisChanger -= decreaseRate;
        y_axisChanger -= decreaseRate;

        if (x_axisChanger < sizeDeadline)
        {
            SelfDestroy();

        }
    }
    //events...................................................................
    private void OnMouseDown()
    {
        gameObject.GetComponent <SpriteRenderer>().sprite = spriteDestroy;
        new WaitForEndOfFrame();
        GettingDestroyed();
       
    }
    
    //.........................................................................
    private void Update()
    {
        GettingSmaller();
    }
}
