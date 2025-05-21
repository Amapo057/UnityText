using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateTarget : MonoBehaviour
{
    public GameObject target;
    float minDistance = 10f;
    Transform player;

    Transform[] destinations;

    // Start is called before the first frame update
    void Start()
    {
        destinations = GetComponentsInChildren<Transform>();
        player = GameObject.Find("player").GetComponent<Transform>();
        Debug.Log("Num of children = " +  destinations.Length);
    }

    public void TargetCreate()
    {
        int index;
        Vector3 position;

        do
        {
            index = Random.Range(1, destinations.Length);
            position = destinations[index].position;

        } while (Vector3.Distance(position, player.position) < minDistance);

        

        GameObject targetc = Instantiate(target, destinations[index].position, Quaternion.identity);
        target.transform.SetParent(destinations[index]);
    }
    // Update is called once per frame
}
