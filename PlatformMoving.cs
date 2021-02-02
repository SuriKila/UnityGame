using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMoving : MonoBehaviour
{
    float dirX;
    public float speed = 1.2f;
    bool movingRight = true;
    public float dis1;
    public float dis2;
    private SpriteRenderer mysprite;

    // Update is called once per frame
    private void Start()
    {
        mysprite = GetComponent<SpriteRenderer>();

    }
    void Update()
    {
        if (transform.position.x > dis1) 
        {
            movingRight = false;
        }
        else if(transform.position.x < dis2)
        {
            movingRight = true;

        }
        if(movingRight)
        {
            transform.position = new Vector2(transform.position.x +speed * Time.deltaTime, transform.position.y);
            
        }
        else
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
            
        }
    
    }
}
