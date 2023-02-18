using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
   
    public void PlayGame()
    {
        Application.LoadLevel("Levels");
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Level1()
    {
        Application.LoadLevel("Game");
    }
    public void Level2()
    {
        Application.LoadLevel("Level2");
    }
    public void Level3()
    {
        Application.LoadLevel("Level3");
    }
    
}
