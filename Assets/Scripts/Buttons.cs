using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void NextLvl2()
    {
        SceneManager.LoadScene(2);
    }
    public void NextLvl3()
    {
        SceneManager.LoadScene(3);
    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
