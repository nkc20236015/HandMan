using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TitleBGM : MonoBehaviour
{
    AudioSource music;
    AudioClip musicClip;
    void Start()
    {
        music = GetComponent<AudioSource>();
        musicClip = GetComponent<AudioClip>();
        music.Stop();

        Invoke("Title",13f);
    }
    void Title()
    {
        music.Play();
    }
}
