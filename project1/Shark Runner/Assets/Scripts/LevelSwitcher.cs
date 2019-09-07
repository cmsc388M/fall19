using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//This class merely holds utility functions that will be called by the UI system and referenced by buttons
public class LevelSwitcher : MonoBehaviour 
{

    public static string MainMenuString = "Main_Menu", GameOverString = "Game_Over", LevelOneString = "Level_1"; 

    public void GoToMainMenu() 
    {
        GameData.ResetPoints();
        SceneManager.LoadScene(MainMenuString);
    }

    public void GoToLevelOne() 
    {
        GameData.ResetPoints();
        SceneManager.LoadScene(LevelOneString);
    }

    public void GoToGameOver() 
    {
        SceneManager.LoadScene(GameOverString);
    }
    
    public void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);
    }

    public void EndGame()
    {
        Application.Quit();
    }

}
