using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCloud : MonoBehaviour
{
    public float moveRange = 5f;
    public float moveSpeed = 0.01f;
    float creatPositionX;

    GameObject player;

    int moveDirection = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player = collision.gameObject;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        player = null;
    }
    // Start is called before the first frame update
    void Start()
    {
        this.moveRange = Random.Range(2f, 4f);
        this.moveSpeed = Random.Range(0.01f, 0.05f);
        this.creatPositionX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * moveDirection * moveSpeed);

        if (player != null)
        {
            player.transform.Translate(Vector3.right * moveDirection * moveSpeed);
        }

        if (transform.position.x > creatPositionX + moveRange)
        {
            moveDirection = -1;
        }

        else if (transform.position.x < creatPositionX - moveRange)
        {
            moveDirection = 1;
        }
    }
}
