using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monet : MonoBehaviour
{

    //public GameObject audioPlay;
    CoinMelody CoinMelodys;
    CoinCount coinCount;

    void Start()
    {
        coinCount = GameObject.FindObjectOfType<CoinCount>();
        CoinMelodys = GameObject.FindObjectOfType<CoinMelody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, 0, 1), 4);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject)
        {
            coinCount.TakeCoin();

            CoinMelodys.ActiveSound();
            Destroy(gameObject);

        }
    }
}
