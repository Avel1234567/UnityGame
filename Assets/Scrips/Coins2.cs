using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins2 : MonoBehaviour
{
    public static int Coin2;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            Coin2 += 1;
            Destroy(gameObject);
        }
    }
}
