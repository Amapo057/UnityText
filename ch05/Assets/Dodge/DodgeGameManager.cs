using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class DodgeGameManager : MonoBehaviour
{
    public GameObject arrow;
    public GameObject item;
    public GameObject hp;
    public GameObject number;
    public GameObject player;
    public GameObject over;
    public GameObject reStart;

    float spawnDelay = 0.4f;
    float spawnTime = 0f;
    int spawnType = 0;
   
    float scoreTime = 0f;
    public float score = 0f;

    public bool end = false;

    void Start()
    {
        over.gameObject.SetActive(false);
        reStart.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (end != true)
        {
            spawnTime += Time.deltaTime;
            scoreTime += Time.deltaTime;
            if (spawnTime > spawnDelay)
            {
                int spawn = Random.Range(1, 21);
                int x = Random.Range(-8, 9);

                if (spawn > 1)
                {
                    GameObject arrowSpawn1 = Instantiate(arrow);
                    if (spawnType == 0)
                    {
                        arrowSpawn1.transform.position = new Vector3(x, 6.5f, 0);
                        spawnType += 1;
                    }
                    else
                    {
                        float playerX = player.transform.position.x;
                        float randomNumber = Random.Range(-2f, 2f);
                        float pX = playerX + randomNumber;
                        arrowSpawn1.transform.position = new Vector3(pX, 6.5f, 0);
                        spawnType -= 1;
                    }
                }
                else
                {
                    GameObject itemSpawn = Instantiate(item);
                    itemSpawn.transform.position = new Vector3(x, 6.5f, 0);
                }

                spawnTime = 0;
            }
            if (scoreTime > 0.3f)
            {
                score += 2;
                scoreTime = 0;
                if (score <= 350)
                {
                    spawnDelay = 0.4f - (score * 0.0009f);
                }
            }
            if (hp.GetComponent<Image>().fillAmount <= 0.1f)
            {
                end = true;
            }
        }
        else
        {
            over.gameObject.SetActive(true);
            reStart.gameObject.SetActive(true);
        }
        
        number.GetComponent<TextMeshProUGUI>().text = score.ToString("F0");

    }
    public void ReloadScene()
    {
        string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentScene);
    }
}
