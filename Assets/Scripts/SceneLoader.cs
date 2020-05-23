using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentIndex + 1);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadFirstLevel()
    {
        ResetPlayerLives();
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    private void ResetPlayerLives()
    {
        var instanceOfGameSession = FindObjectOfType<GameSession>();

        if (!instanceOfGameSession)
        {
            return;
        }

        instanceOfGameSession.ResetPlayerLives();
    }
}
