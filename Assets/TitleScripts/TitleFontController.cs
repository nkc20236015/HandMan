using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class TitleFontController : MonoBehaviour
{
    void Start()
    {
        gameObject.SetActive(false);
        Invoke("Font",12.5f);
    }

    void Font()
    {
        gameObject.SetActive(true);
    }
    
}
