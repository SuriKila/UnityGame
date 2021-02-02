using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMove : MonoBehaviour
{
    // Start is called before the first frame update
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
        if (transform.position.y > dis1)
        {
            movingRight = false;
        }
        else if (transform.position.y < dis2)
        {
            movingRight = true;

        }
        if (movingRight)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + speed * Time.deltaTime);
            
        }
        else
        {
            transform.position = new Vector2(transform.position.x , transform.position.y - speed * Time.deltaTime);
            
        }

    }
}
