using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class ControlUI : MonoBehaviour
{
  

    public void LoadNextScene()
    {
        // �� ������ ������ ���� ����� �� ���� ����
        SceneManager.LoadScene("PlayGround");
    }
    public void LoadNextScene1()
    {
        // �� ������ ������ ���� ����� �� ���� ����
        SceneManager.LoadScene("MinMune");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}


