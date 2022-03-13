using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryPlay : MonoBehaviour
{

    public void Retry()
    {
        var lvl = SceneManager.sceneCount;
        Time.timeScale = 1;
        SceneManager.LoadScene(lvl);
    }
}
