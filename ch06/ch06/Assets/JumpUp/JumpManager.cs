using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class JumpManager : MonoBehaviour
{
    public static int stage = 1;
    public static int maxStage = 1;

    public TextMeshProUGUI stageText;
    public TextMeshProUGUI maxStageText;


    // Update is called once per frame
    void Update()
    {
        stageText.text = "Stage: " + stage.ToString();

        if (stage > maxStage)
        {
            maxStage = stage;
        }

        if (maxStageText != null)
        {
            maxStageText.text = "Best Stage: " + maxStage.ToString();
        }
    }
}
