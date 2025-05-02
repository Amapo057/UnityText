using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpButton : MonoBehaviour
{


    void Update()
    {

    }

    public void RestartGame()
    {
        SceneManager.LoadScene("JumpUpStage1");
        JumpManager.stage = 1;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
     
}
