using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject apple;
    public GameObject bomb;

    float span = 1f;
    float delta = 0f;



    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;

        if(delta >= span)
        {
            Instantiate(apple);
            delta = 0f;
        }
    }
}
