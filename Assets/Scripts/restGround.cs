using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restGround : MonoBehaviour
{
    Vector2 spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>().sprite.bounds.size;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x + spriteRenderer.x < 0)
        {
            transform.position += spriteRenderer.x * 2 * Vector3.right;
        }
        
    }
}
