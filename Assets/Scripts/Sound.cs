using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public AudioSource death;
    public AudioSource coin;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Did")
        {
            death.Play();
        }
        else if (other.gameObject.tag == "Score")
        {
            coin.Play();
        }
        else if (other.gameObject.tag == "pipes")
        {
            death.Play();
        }


    }
}
