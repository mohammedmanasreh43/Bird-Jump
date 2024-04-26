using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public Sound soundEffict;
    public GameObject soundManager;

    private int spriteIndex;
    public Sprite[] sprites;
    private SpriteRenderer spriteRenderer;

    private Vector3 direction;


    public float gravtiy = -9.8f;
    public float strength = 5f;

    private Rigidbody2D rb;

   


    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
       

    }

    private void Start()
    {
        
        InvokeRepeating(nameof(AnimateSprite), 0.15f, 0.15f);
        
    }

    void Update()
    {
      movePlayer();

        

    }
    void movePlayer()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
             direction= Vector3.up * strength;



        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                direction = Vector3.up * strength;


            }
        }
        if(direction.y > 0)
        {
            float angel = 0;
            angel=Mathf.Lerp(0,45,direction.y/7);
            transform.rotation =Quaternion.Euler(0,0,angel);    

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
    private void AnimateSprite()
    {
        spriteIndex++;
        if(spriteIndex >= sprites.Length)
        {
            spriteIndex = 0;
            
        }

        spriteRenderer.sprite = sprites[spriteIndex];
        
    }
    private void OnEnable()
    {
        Vector3 position = transform.position;
        position.y = 0f;
        transform.position = position;
       direction = Vector3.zero;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Did")
        {
           
            FindObjectOfType<GameManager>().GameOver();
            

        }
        else if (other.gameObject.tag == "Score")
        {
            FindObjectOfType<GameManager>().IncreaseScore();
            
            
        }
        else if (other.gameObject.tag == "pipes")
        {
            
            FindObjectOfType<GameManager>().GameOver();
            
        }
        else if (other.gameObject.CompareTag("Ground"))
        {
            FindObjectOfType<GameManager>().stopPlayer();

        }

    }
    
}
