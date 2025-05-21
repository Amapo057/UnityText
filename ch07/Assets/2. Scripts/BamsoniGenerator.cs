using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsoniGenerator : MonoBehaviour
{
    public GameObject bamsongiPrefab;
    float power = 0f;
    float startVal = 0f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bamsongi = Instantiate(bamsongiPrefab, transform.position, transform.rotation);

            bamsongi.transform.position = new Vector3(transform.position.x, transform.position.y +1, transform.position.z+2);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;

            //bamsongi.GetComponent<BamsongiController>().Shoot(new Vector3(0, 500, 2500s);
            bamsongi.GetComponent<BamsongiController>().Shoot(worldDir * 2000);
        }
        if (Input.GetMouseButtonUp(0))
        {
            power = Input.mousePosition.y - startVal;

            bamsongiPrefab.GetComponent<BamsongiController>().Shoot((Transform.forward + transform.up).normalized, power * 10 );

        }
    }
}
