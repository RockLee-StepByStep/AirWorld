using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class boxJump : MonoBehaviour
{
    CoinCount numberCoin;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        numberCoin = GameObject.FindObjectOfType<CoinCount>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && numberCoin.numbersCoin!=0)
        {
            Debug.Log(777);
            other.GetComponent<Rigidbody>().AddForce(new Vector3(0.4f,1.4f,-1)* 5, ForceMode.Impulse);
        }

        if(other.gameObject.CompareTag("Player")&&numberCoin.numbersCoin == 0)
        {
            audioSource.Play();
        }
    
    }
}
