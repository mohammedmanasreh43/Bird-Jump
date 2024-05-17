using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;
using UnityEngine.SceneManagement;

public class LoadSc : MonoBehaviour
{
    public GameObject load;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        AnimateBar();
        Invoke("LoadNextScene", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AnimateBar()
    {
        LeanTween.scaleX(load,1,time);
    }
    void LoadNextScene()
    {
        // Load the next scene by name
        SceneManager.LoadScene("MinMune");
    }
}
