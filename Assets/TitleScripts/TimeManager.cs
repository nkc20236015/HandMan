using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject box;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        box = GameObject.Find("box");
        Invoke("box_gravity",8.0f);

    }
    void box_gravity()
    {
        Physics.gravity = new Vector3(0, 3, 0);
    }
}
