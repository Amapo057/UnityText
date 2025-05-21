using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    Transform playerTR;
    GenerateTarget gt;

    // Start is called before the first frame update
    void Start()
    {
        playerTR = GameObject.Find("player").transform;
        gt = GameObject.FindAnyObjectByType<GenerateTarget>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(playerTR);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        Destroy(collision.gameObject);
        gt.TargetCreate();
    }
}
