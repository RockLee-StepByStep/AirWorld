using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMelody : MonoBehaviour
{
    AudioSource melodyPlay;
    void Start()
    {
        melodyPlay = GetComponent<AudioSource>();
    }

   
    public void ActiveSound()
    {
        melodyPlay.Play();
    }
}
