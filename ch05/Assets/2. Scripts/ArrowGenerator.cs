using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float span = 1.0f;
    float delta = 0f;

    void Update()
    {
        delta += Time.deltaTime;
        if (delta > span)
        {
            GameObject go = Instantiate(arrowPrefab);
            int px = Random.Range(-9, 10);
            go.transform.position = new Vector3(px, 6.5f, 0);
            delta = 0;
        }
    }
}
