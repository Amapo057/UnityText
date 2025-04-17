using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        DodgePlayer player = collision.gameObject.GetComponent<DodgePlayer>();
        if (player != null)
        {
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        if (transform.position.y < -7)
        {
            Destroy(gameObject);
        }
    }
}