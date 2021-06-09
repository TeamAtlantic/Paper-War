using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{

    //public GameObject wholeGame;
    public GameObject gameCanvas;
    public GameObject mainMenu;

    public void Update()
    {
        Time.timeScale = 0;
    }


    public void StartGame()
    {
        mainMenu.SetActive(false);
        //wholeGame.SetActive(true);
        gameCanvas.SetActive(true);
    }

    public void QuitGame()
    {
        Debug.Log("YOU CANNOT QUIT (YET)");
    }

}
