using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backController : MonoBehaviour
{
    void Update()
    {
        transform.Translate(-0.001f,0,0);
        if(transform.position.x < -26.5f)
        {
            transform.position = new Vector3(8.97f,0,0);
        }
    }
}
