using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public GameObject hp_guage;
    // Start is called before the first frame update
    void Start()
    {
        //hp_guage = GameObject.Find("hp_guage");
    }

    public void DecreaseHp()
    {
        hp_guage.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
