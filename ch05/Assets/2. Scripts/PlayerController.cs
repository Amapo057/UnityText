using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlar : MonoBehaviour
{
    public float moveStep = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-moveStep, 0, 0);
        }

        if(Input.GetKeyDown(KeyCode.RightArrow)) 
        {
            transform.Translate(moveStep, 0, 0);
        }
    }
    public void LButtonDown()
    {
        transform.Translate(-moveStep, 0, 0);
    }

    public void RButtonDown()
    {
        transform.Translate(moveStep, 0, 0);
    }
}
