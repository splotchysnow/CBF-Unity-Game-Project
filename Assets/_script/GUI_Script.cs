using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GUI_Script : MonoBehaviour
{

    //give the game instruction when how to play is pressed.
    public void howToPlayButton() {
        SceneManager.LoadScene("HowToPlay");
    }

    //for when start button is clicked
    public void onClickStart()
    {
        SceneManager.LoadScene("Scene_01");
    }

    //for when exit button is clicked;
    public void exitGame()
    {
        print("Game is ended.");
        Application.Quit();
    }

    //when the menu button is pressed: go back to GUI scene
    public void backToMenu()
    {
        SceneManager.LoadScene("GUI");
    }
}
