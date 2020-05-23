using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{
    [SerializeField] int playerStartingLives = 3;
    [SerializeField] int playerLives = 3;

    private void Awake()
    {
        int currentNumberOfInstances = FindObjectsOfType<GameSession>().Length;

        if (currentNumberOfInstances > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void ProcessPlayerDeath()
    {
        if (playerLives > 1)
        {
            playerLives--;
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentSceneIndex);
        }
        else
        {
            SceneManager.LoadScene("Game Over");
        }
    }

    public void ResetPlayerLives()
    {
        playerLives = playerStartingLives;
    }
}
