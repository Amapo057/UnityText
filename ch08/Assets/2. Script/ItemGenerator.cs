using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject apple;
    public GameObject bomb;

    float bombRatio = 0.2f;
    float span = 1f;
    float delta = 0f;
    float speed = -0.03f;

    public void SetParameters(float span,float speed, float bombRatio)
    {
        this.span = span;
        this.speed = speed;
        this.bombRatio = bombRatio;
    }


    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;

        if(delta >= span)
        {
            GameObject item;
            float dice = Random.Range(0f, 1f);
            if (dice < bombRatio)
            {
                item = Instantiate(bomb);
            }
            else
            {
                item= Instantiate(apple);
            }
            float x = Random.Range(-1, 2);
            float z = Random.Range(-1, 2);
            item.transform.position = new Vector3(x, 4f, z);
            item.GetComponent<ItemController>().dropSpeed = speed;

            delta = 0f;
        }
    }
}
