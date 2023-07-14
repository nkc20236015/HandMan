using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxController : MonoBehaviour
{
    Rigidbody2D rd;
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
        Invoke("box_gravity", 8.0f);
    }
    void box_gravity()
    {
        rd.gravityScale = 3;
    }
    void Update()
    {
        
    }
}
