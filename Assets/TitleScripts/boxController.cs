using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxController : MonoBehaviour
{
    Rigidbody2D rd;
    public AudioClip se;
    AudioSource audiosource1;
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
        audiosource1 = GetComponent<AudioSource>();

        Invoke("box_gravity", 8.0f);

    }
    void box_gravity()
    {
        rd.gravityScale = 3;
    }
    void Update()
    {
       
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("è∞Ç…êGÇÍÇΩ");
        if(col.gameObject.tag == "floor")
        {
            audiosource1.PlayOneShot(se);
        }
    }
}
