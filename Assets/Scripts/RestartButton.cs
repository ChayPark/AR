using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public void RestartGame(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void ReloadCurrenrtScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}