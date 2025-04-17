using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgeGameManager : MonoBehaviour
{
    public GameObject arrow;
    public GameObject item;
    public GameObject hp;
    public GameObject number;

    float delay = 0.7f;
    float delta = 0f;

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > delay)
        {
            int spawn = Random.Range(1, 11);
            int x = Random.Range(-8, 9);

            if (spawn > 2)
            {
                GameObject arrowSpawn = Instantiate(arrow);
                arrowSpawn.transform.position = new Vector3(x, 6.5f, 0);
            }
            else
            {
                GameObject itemSpawn = Instantiate(item);
                itemSpawn.transform.position = new Vector3(x, 6.5f, 0);
            }

                delta = 0;
        }

    }
}
