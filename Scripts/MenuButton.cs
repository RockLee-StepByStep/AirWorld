using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
   public void Pause()
    {
        if (this.gameObject)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
            
    }

   

}
