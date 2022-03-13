using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LvLManager : MonoBehaviour
{
    // Start is called before the first frame update


    public void PLayeGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void ExitGame()
    {
        Debug.Log("13");
        Application.Quit();
    }
    
}
