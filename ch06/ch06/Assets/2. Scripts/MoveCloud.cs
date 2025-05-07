using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCloud : MonoBehaviour
{
    public float avgSpeed = 0.05f;
    float range = 0.02f;
    public float maxWidth;

    float moveSpeed;
    int direction = 1;


    // Update is called once per frame
    void Update()
    {
        moveSpeed = avgSpeed;

        if(transform.position.x > maxWidth)
        {
            moveSpeed = Random.Range(0, avgSpeed - range);
            direction = -1;
        }
        if(transform.position.x < -maxWidth)
        {
            direction = 1;
        }
        transform.Translate(moveSpeed*direction, 0, 0);

    }
}
