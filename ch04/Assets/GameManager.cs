using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject car;
    public GameObject flag;
    public GameObject distance;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float length = flag.transform.position.x - this.car.transform.position.x;
        distance.GetComponent<TextMeshProUGUI>().text = "°Å¸®: " + length.ToString("F2") + "m";

    }
    public viod QuitGame()
    {
        Application.Quit();
    }
}
