using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    [SerializeField] float speed = 3f;
    bool moveingUp = true;
    private void Update()
    {
        if (transform.position.y > 1.88f)
        {
            moveingUp = false;
        }
        else if (transform.position.y < -3f)
        {
            moveingUp = true;
        }
        if (moveingUp)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + speed * Time.deltaTime);
        }
        else
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - speed * Time.deltaTime);
        }
    }
}
