using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GUI_Script : MonoBehaviour
{



    public void onClickStart()
    {
        SceneManager.LoadScene("Scene_01");
    }
    public void exitGame()
    {
        print("Game is ended.");
        Application.Quit();
    }
}
