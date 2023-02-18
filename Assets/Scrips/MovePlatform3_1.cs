using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform3_1 : MonoBehaviour
{
    [SerializeField] float speed = 3f;

    bool moveRight = true;

    private void Update()
    {
        if (transform.position.x > 1.38f)
        {
            moveRight = false;
        }
        else if (transform.position.x < -5.87f)
        {
            moveRight = true;
        }

        if (moveRight)
        {
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        }
    }


}
