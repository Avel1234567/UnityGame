using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    float dirX;
    [SerializeField]float speed = 3f;
    bool moveingRight = true;
    private void Update()
    {
        if(transform.position.x > -12.47f)
        {
            moveingRight = false;
        }
        else if(transform.position.x < -14.47f)
        {
            moveingRight = true;
        }
        if(moveingRight)
        {
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        }
    }
}
