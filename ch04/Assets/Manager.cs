using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
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
        flag = GameObject.Find("flag");
        car = GameObject.Find("car");
        distance = GameObject.Find("Distance");

        float length = flag.transform.position.x - this.car.transform.position.x;
        if (length == 14.5)
        {
            distance.GetComponent<TextMeshProUGUI>().text = "뒤로 당기세요!";
        }
        else
        {
            distance.GetComponent<TextMeshProUGUI>().text = "거리: " + length.ToString("F2") + "m";
        }
    
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void ReloadScene()
    {
        string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentScene);
    }
}
