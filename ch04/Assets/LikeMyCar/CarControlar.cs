using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControlar : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 0;
    public float speedRatio = 500;
    public float startSpeed = 0.2f;
    public float stopSpeed = 0.03f;

    Vector2 startPos;
    Vector2 endPos;
    AudioSource carAudio;

    bool gameEnded = false;
    bool carStarted = false;

    void Start()
    {
        Application.targetFrameRate = 60;
        carAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameEnded) return;
        if (Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition;
        }

        else if (Input.GetMouseButtonUp(0))
        {
            endPos = Input.mousePosition;
            float swipeLength = endPos.x - startPos.x;

            this.speed = swipeLength / speedRatio;
            
            carAudio.Play();
            carStarted = true;
        }
        transform.Translate(this.speed, 0, 0);


        this.speed *= 0.98f;

        if (carStarted && this.speed < 0.01)
        {
            this.speed = 0f;
            gameEnded = true;
        }
    }


}
