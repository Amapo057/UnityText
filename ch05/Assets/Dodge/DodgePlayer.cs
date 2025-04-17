using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgePlayer : MonoBehaviour
{
    public float moveStep = 0.3f;
    int moveDirection = 0;
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
            moveDirection -= 1;
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            moveDirection += 1;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)) 
        {
            moveDirection += 1;
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            moveDirection -= 1;
        }
        transform.Translate(moveStep * moveDirection, 0, 0);

    }
}
