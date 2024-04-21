using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class ControlUI : MonoBehaviour
{
  

    public void LoadNextScene()
    {
        // Şã ÈÊÍãíá ÇáãÔåÏ ÇáĞí ÊÑíÏå Úä ØÑíŞ ÇÓãå
        SceneManager.LoadScene("PlayGround");
    }
    public void LoadNextScene1()
    {
        // Şã ÈÊÍãíá ÇáãÔåÏ ÇáĞí ÊÑíÏå Úä ØÑíŞ ÇÓãå
        SceneManager.LoadScene("MinMune");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}


