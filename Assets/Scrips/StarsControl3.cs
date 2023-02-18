using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsControl3 : MonoBehaviour
{
    public GameObject star7, star8, star9;
    public static int open_star7, open_star8, open_star9;
    void Start()

    {

        open_star7 = PlayerPrefs.GetInt("stars7", 1);
        open_star8 = PlayerPrefs.GetInt("stars8", 1);
        open_star9 = PlayerPrefs.GetInt("stars9", 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (open_star7 == 1)
        {
            star7.SetActive(false);
        }

        if (open_star7 == 2)
        {
            star7.SetActive(true);
        }

        if (open_star8 == 1)
        {
            star8.SetActive(false);
        }

        if (open_star8 == 2)
        {
            star8.SetActive(true);
        }

        if (open_star9 == 1)
        {
            star9.SetActive(false);
        }

        if (open_star9 == 2)
        {
            star9.SetActive(true);
        }


        // ===================


        if (Coins3.Coin3 >= 2)
        {
            openStar7();
        }

        if (Coins3.Coin3 >= 4)
        {
            openStar8();
        }

        if (Coins.Coin >= 6)
        {
            openStar9();
        }
    }


    public void openStar7()
    {
        open_star7 = 2;
        PlayerPrefs.SetInt("stars7", open_star7);
    }

    public void openStar8()
    {
        open_star8 = 2;
        PlayerPrefs.SetInt("stars8", open_star8);
    }

    public void openStar9()
    {
        open_star9 = 2;
        PlayerPrefs.SetInt("stars9", open_star9);
    }
}
