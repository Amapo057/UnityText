using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BasketController : MonoBehaviour
{
    public AudioClip appleSE;
    public AudioClip bombSE;

    GameObject manager;

    private AudioSource aud;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        aud = GetComponent<AudioSource>();
        manager = GameObject.Find("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                float x = Mathf.RoundToInt(hit.point.x);
                float z = Mathf.RoundToInt(hit.point.z);
                transform.position = new Vector3(x, 0, z);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Apple")
        {
            Debug.Log("»ç°ú");
            aud.PlayOneShot(appleSE);
            manager.GetComponent<GameManager>().GetApple();
        }
        else if (other.gameObject.tag == "Bomb")
        {
            Debug.Log("ÆøÅº");
            aud.PlayOneShot(bombSE);
            manager.GetComponent<GameManager>().GetBomb();
        }
        Destroy(other.gameObject);
    }
}
