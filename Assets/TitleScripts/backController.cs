using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backController : MonoBehaviour
{
    void Update()
    {
        transform.Translate(-0.1f,0,0);
        if(transform.position.x < -21f)
        {
            transform.position = new Vector3(13f,0,0);
        }
    }
}
