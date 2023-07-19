using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController2 : MonoBehaviour
{
    AudioSource audiosource;

    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        audiosource.Play();
        Invoke("BGM",8f);
    }
    void BGM()
    {
        audiosource.Stop();
    }
}
