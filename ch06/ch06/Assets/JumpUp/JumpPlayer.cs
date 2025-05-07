using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpPlayer : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;

    float jumpForce = 400f;
    float walkSpeed = 0.08f;

    bool jump = false;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        rigid2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        jump = true;
        animator.SetBool("playerJump", false);
        if (other.gameObject.tag == "Flag")
        {
            string activeScene = SceneManager.GetActiveScene().name;

            JumpManager.stage++;
            if (activeScene == "JumpUpStage1")
            {
                SceneManager.LoadScene("JumpUpStage2");
            }
            else if (activeScene == "JumpUpStage2")
            {
                SceneManager.LoadScene("JumpUpStage2");
            }
        }
        if (other.gameObject.tag == "Lava") {
            SceneManager.LoadScene("JumpUpEnd");
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        jump = false;
        animator.SetBool("playerJump", true);
        animator.SetBool("playerWalk", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (jump)
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                rigid2D.AddForce(transform.up * jumpForce);
                //rigid2D.AddForce(new Vector2(0, 1) * jumpForce);
            }
        }
        if (jump == true)
        {
            animator.SetBool("playerWalk", false);
        }

        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) { key = 1; }
        if (Input.GetKey(KeyCode.LeftArrow)) { key = -1; }

        if (key != 0)
        {
            transform.Translate(Vector3.right * key * walkSpeed);
            if (jump == true)
            {
                animator.SetBool("playerWalk", true);
            }
        }

        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

    }

}
