using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsControl2 : MonoBehaviour
{
    public GameObject star4, star5, star6;
    public static int open_star4, open_star5, open_star6;
    void Start()

    {
        

        open_star4 = PlayerPrefs.GetInt("stars4", 1);
        open_star5 = PlayerPrefs.GetInt("stars5", 1);
        open_star6 = PlayerPrefs.GetInt("stars6", 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (open_star4 == 1)
        {
            star4.SetActive(false);
        }

        if (open_star4 == 2)
        {
            star4.SetActive(true);
        }

        if (open_star5 == 1)
        {
            star5.SetActive(false);
        }

        if (open_star5 == 2)
        {
            star5.SetActive(true);
        }

        if (open_star6 == 1)
        {
            star6.SetActive(false);
        }

        if (open_star6 == 2)
        {
            star6.SetActive(true);
        }


        // ===================


        if (Coins2.Coin2 >= 2)
        {
            openStar4();
        }

        if (Coins2.Coin2 >= 4)
        {
            openStar5();
        }

        if (Coins2.Coin2 >= 6)
        {
            openStar6();
        }
    }


    public void openStar4()
    {
        open_star4 = 2;
        PlayerPrefs.SetInt("stars4", open_star4);
    }

    public void openStar5()
    {
        open_star5 = 2;
        PlayerPrefs.SetInt("stars5", open_star5);
    }

    public void openStar6()
    {
        open_star6 = 2;
        PlayerPrefs.SetInt("stars6", open_star6);
    }
}
