using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coinText : MonoBehaviour
{

    TMP_Text textUI;
    CoinCount coinCount;

    // Start is called before the first frame update
    void Start()
    {
        coinCount = GameObject.FindObjectOfType<CoinCount>();



        textUI = GetComponent<TMP_Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        textUI.text = $"I have {coinCount.numbersCoin} coins left";
    }
}
