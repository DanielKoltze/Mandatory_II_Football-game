using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayMenu : MonoBehaviour
{
    private bool levelOneCleared = false;
    private bool levelTwoCleared = false;
    public GameObject levelTwoField;
    public GameObject levelThreeField;
    public void LoadLevel(string levelName)
    {
        if(levelName == "Level1" ||
            levelName == "Level2" && levelOneCleared ||
            levelName == "Level3" && levelTwoCleared)
        {
            SceneManager.LoadScene(levelName);
        }
        
        
    }
    private void Start()
    {
        levelTwoField.SetActive(levelOneCleared);
        levelThreeField.SetActive(levelTwoCleared);
    }

}
