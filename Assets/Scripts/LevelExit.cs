using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExit : MonoBehaviour
{
    [SerializeField] float delaySceneLoad = 0.5f;
    [SerializeField] float levelExitSlowMotionFactor = 0.2f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(DelayNextSceneLoad());
    }

    IEnumerator DelayNextSceneLoad()
    {
        Time.timeScale = levelExitSlowMotionFactor;
        yield return new WaitForSeconds(delaySceneLoad);
        Time.timeScale = 1f;

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
