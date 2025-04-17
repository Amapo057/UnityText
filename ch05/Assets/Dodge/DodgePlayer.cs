using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DodgePlayer : MonoBehaviour
{
    public GameObject hp;
    public GameObject GameManager;
    private DodgeGameManager score;

    public float moveStep = 0.3f;
    int moveDirection = 0;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Arrow"))
        {
            hp.GetComponent<Image>().fillAmount -= 0.34f;
        }
        else
        {
            score = GameManager.GetComponent<DodgeGameManager>();
            score.score += 30;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            moveDirection -= 1;
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            moveDirection += 1;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)) 
        {
            moveDirection += 1;
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            moveDirection -= 1;
        }
        transform.Translate(moveStep * moveDirection, 0, 0);


    }
}
