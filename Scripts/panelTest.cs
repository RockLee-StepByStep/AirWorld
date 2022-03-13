using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class panelTest : MonoBehaviour
{
   [SerializeField] public Color tempColor;
    [SerializeField] public float tryed;

    public Image image;
    void Start()
    {
        image = GetComponent<Image>();
        StartCoroutine(changeAlfa());
    }

   

    IEnumerator changeAlfa()
    {
        tempColor = image.color;
        tryed = 0;
        for(float i = 0; i <= 0.5; i+=.01f)
        {
            tryed += i;
            tempColor.a += i;
            yield return new WaitForSecondsRealtime(.1f);
            yield return new WaitUntil(() => tryed <= 0.65);
            
            image.color = tempColor;
            Debug.Log(1);
        }
       
        
       
        
        
    }


   
}
