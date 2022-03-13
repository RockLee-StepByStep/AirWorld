using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCount : MonoBehaviour
{
    public List<GameObject> monets = new List<GameObject>();
    public GameObject[] monet;
    public int numbersCoin;

    void Start()
    {
        monet = GameObject.FindGameObjectsWithTag("coin");
        
        monets.AddRange(monet);

        
    }

    private void Update()
    {
        numbersCoin = monets.Count;

    }

     int difCoin()
    {
        return numbersCoin;
    }

    public void TakeCoin()
    {

        monets.Remove(monet[monet.Length - difCoin()]);
    }
 
}
