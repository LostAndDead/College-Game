using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScripts : MonoBehaviour
{
    public void onEasyPress(){
        GameValues.Difficulty = 1;
        GameValues.Lives = 10;
        GameValues.Score = 0;
        SceneManager.LoadScene("LevelScreen", LoadSceneMode.Single);
    }

    public void onMediumPress(){
        GameValues.Difficulty = 2;
        GameValues.Lives = 5;
        GameValues.Score = 0;
        SceneManager.LoadScene("LevelScreen", LoadSceneMode.Single);
    }

    public void onHardPress(){
        GameValues.Difficulty = 3;
        GameValues.Lives = 1;
        GameValues.Score = 0;
        SceneManager.LoadScene("LevelScreen", LoadSceneMode.Single);
    }

    public void onReturnPress(){
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

    public void onExitPress(){
        Application.OpenURL("https://www.youtube.com/watch?v=fC7oUOUEEi4");
        Application.Quit();
    }
}
