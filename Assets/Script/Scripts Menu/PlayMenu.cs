using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayMenu : MonoBehaviour
{
    public void LoadLevel(string levelName)
    {
            SceneManager.LoadScene(levelName);
    }
   
}
