using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins3 : MonoBehaviour
{
    public static int Coin3;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            Coin3 += 1;
            Destroy(gameObject);
        }
    }
}
