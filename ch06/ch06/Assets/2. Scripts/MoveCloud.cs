using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCloud : MonoBehaviour
{
    public float moveSpeed;
    public float maxWidth;
    int direction = 1;


    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > maxWidth)
        {
            direction = -1;
        }
        if(transform.position.x < -maxWidth)
        {
            direction = 1;
        }
        transform.Translate(moveSpeed*direction, 0, 0);

    }
}
