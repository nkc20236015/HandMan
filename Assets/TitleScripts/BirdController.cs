using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class BirdController : MonoBehaviour
{
    AudioSource audiosource;
    public AudioClip clip;

    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        Invoke("Bird",8.5f);
    }
    void Bird()
    {
        audiosource.PlayOneShot(clip);
    }
    void Update()
    {
        
    }
}
