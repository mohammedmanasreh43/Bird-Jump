using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Did : MonoBehaviour
{

    private Vector3 direction;
    public float gravtiy = -9.8f;
    public float strength = 5f;

    private void Start()
    {

       
    }

    void Update()
    {
        movePlayer();



    }
    void movePlayer()
    {
     
            direction = Vector3.up * strength;
      
          
        
        if (direction.y > 0)
        {
            float angel = 0;
            angel = Mathf.Lerp(0, 45, direction.y / 7);
            transform.rotation = Quaternion.Euler(0, 0, angel);

        }
        else if (direction.y < 0)
        {
            float angel = 0;
            angel = Mathf.Lerp(0, -45, -direction.y / 7);
            transform.rotation = Quaternion.Euler(0, 0, angel);

        }
        direction.y += gravtiy * Time.deltaTime;
        transform.position += direction * Time.deltaTime;
    }
    
}
   


