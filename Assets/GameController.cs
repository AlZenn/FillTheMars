using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject[] panels;
    void Start()
    {
        Time.timeScale = 0f;
    }

    public void gameStart()
    {
        panels[0].SetActive(false);
        Time.timeScale = 1f;
    }

    public void gameResume()
    {
        panels[1].SetActive(false);
        Time.timeScale = 1f;
    }

    public void gameFreeze()
    {
        Time.timeScale = 0f;
    }public void gameContuniue()
    {
        Time.timeScale = 1f;
    }
    public void gameExit()
    {
        Application.Quit();
    }

    public void gameMainMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 0f;
    }

}
