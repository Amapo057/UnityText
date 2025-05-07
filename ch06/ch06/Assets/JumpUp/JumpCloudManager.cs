using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class JumpCloudManager : MonoBehaviour
{
    public GameObject stopCloud;
    public GameObject moveCloud;

    float cloudY = -2f;
    float beforeCloudX = 0f;
    Vector3 cloudPosition;

    // Start is called before the first frame update
    void Start()
    {
        while (cloudY <= 21f)
        {
            float nowCloudX = Random.Range(-4.5f, 4.5f) + beforeCloudX;

            if (nowCloudX >= -8 && nowCloudX <= 8)
            {
                cloudPosition = new Vector3(nowCloudX, cloudY, 0); 
            }
            else
            {
                cloudPosition = new Vector3(nowCloudX / Mathf.Abs(nowCloudX) * 8, cloudY, 0);
            }

            if (Random.Range(0, 6) >= 3)
            {
                GameObject cloud = Instantiate(moveCloud, cloudPosition, Quaternion.identity);
            }
            else
            {
                GameObject cloud = Instantiate(stopCloud, cloudPosition, Quaternion.identity);
            }
            cloudY += Random.Range(2f, 3f);
        }
        
    }
}
