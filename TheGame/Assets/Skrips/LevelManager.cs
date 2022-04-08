using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void LoadIt(string level)
    {
        SceneManager.LoadScene(level);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
