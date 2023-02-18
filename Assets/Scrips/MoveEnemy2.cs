using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy2 : MonoBehaviour
{
    float dirX;
    [SerializeField] float speed = 3f;

    bool moveingRight = true;

    private void Update()
    {
        if (transform.position.x > 12.46f)
        {
            moveingRight = false;
        }
        else if (transform.position.x < 7.67f)
        {
            moveingRight = true;
        }

        if (moveingRight)
        {
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        }
    }
}
