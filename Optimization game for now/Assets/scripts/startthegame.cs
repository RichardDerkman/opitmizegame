using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class startthegame : MonoBehaviour
{
     public GameObject Mainmenu;

    // ------------ (BUTTON) Start New Game -----------
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    // ------------ (BUTTON) Exit Game -----------
    public void ExitGame()
    {
        Debug.Log("Exited game");
        Application.Quit();
    }
}
