using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{

   // burde kun virker efter en build
   public void QuitGame()
    {
        Debug.Log("Quit game");
        Application.Quit();
    }
}
