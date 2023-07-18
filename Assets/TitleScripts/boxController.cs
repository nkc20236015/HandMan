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
        Invoke("box_gravity", 8.0f);

        audiosource1 = GetComponent<AudioSource>();
    }
    void box_gravity()
    {
        rd.gravityScale = 3;
    }
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision col)
    {
        if(tag == "floor")
        {
            audiosource1.PlayOneShot(se);
        }
    }
}
