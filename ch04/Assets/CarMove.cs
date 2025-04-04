using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 0;
    public float speedRatio = 650;
    public float startSpeed = 0.2f;
    public float stopSpeed = 0.03f;
    public float noise;

    Vector2 startPos;
    Vector2 endPos;
    AudioSource carAudio;

    bool carStarted = false;

    void Start()
    {
        Application.targetFrameRate = 60;
        carAudio = GetComponent<AudioSource>();
        noise = Random.Range(1, 9); // 랜덤성 추가해서 변수 생성
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition;
        }

        else if (carStarted == false && Input.GetMouseButtonUp(0))
        {
            endPos = Input.mousePosition;
            float swipeLength = startPos.x - endPos.x;
            if (swipeLength < 0)
            {
                swipeLength = 0;
                return;
            }
            this.speed = swipeLength / speedRatio;
            
            carAudio.Play();
            carStarted = true;
        }
        transform.Translate(this.speed, 0, 0);


        this.speed *= 0.97f + (noise * 0.001f);

        if (carStarted && this.speed < 0.01)
        {
            this.speed = 0f;
        }
    }


}
