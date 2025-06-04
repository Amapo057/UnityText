using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawSpheres : MonoBehaviour
{
    public GameObject spherePrefeb;
    public Camera mainCamera;

    GameManager gameManager;
    float minDistance = 0.2f;
    Vector3 prevPosition = new Vector3(0, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.isDrawing == false) return;

        Vector3 currentPosition = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width/2, Screen.height/2, 0.5f));

        float distance = Vector3.Distance(currentPosition, prevPosition);
        if (distance < minDistance) return;

        GameObject go = Instantiate(spherePrefeb, currentPosition, transform.rotation);
        go.transform.parent = transform;
        prevPosition = currentPosition;
    }
}
