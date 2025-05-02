using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;
    float jumpForce = 300f;
    public float walkForce = 100f;
    float maxWalkSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        rigid2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && rigid2D.velocity.y == 0)
        {
            rigid2D.AddForce(transform.up * jumpForce);
            //rigid2D.AddForce(new Vector2(0, 1) * jumpForce);
        }
        int key = 0;
        if(Input.GetKey(KeyCode.RightArrow)) { key = 1; }
        if(Input.GetKey(KeyCode.LeftArrow)) { key = -1; }

        float speedX = Mathf.Abs(rigid2D.velocity.x);

        if (speedX < maxWalkSpeed)
        {
            rigid2D.AddForce(transform.right * key * walkForce);
        }

        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        if (transform.position.y < -10)
        {
            SceneManager.LoadScene("GameScene");
        }

        animator.speed = speedX / 2.0f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Goal");
        SceneManager.LoadScene("ClearScene");
    }
}
