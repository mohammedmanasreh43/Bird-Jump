using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text Score;
    public Text HighScore;

    public int score = 0;
    public int highscore= 0;


    public PlayerJump player;
    public Spawner spawner;


    public MoveGround moveGround;
    public Pipes pipess;
    public Did did;
    public GameObject gameOver;
    public GameObject myPrefab;
    public GameObject pplayer;
    public GameObject ground;
    public GameObject Menudid;

    public GameObject playButton;
    
    
    private float yOffset=1.10f;

    public void Awake()
    {
        Application.targetFrameRate = 60;
        gameOver.gameObject.SetActive(false);
        did.enabled = false;
        player.enabled = false;

        Pause();
    }
    public void Pause()
    {
        Time.timeScale = 0;
        // player.enabled = false;


    }
    public void play()
    {
        score = 0;
        Score.text = score.ToString();
        UpdateUI();

        Time.timeScale = 1;

        player.enabled = true;
        spawner.enabled = true;
        moveGround.enabled = true;
        pipess.enabled = true;
        did.enabled = false;
        Menudid.SetActive(false);


        gameOver.SetActive(false);
        playButton.SetActive(false);



        GameObject[] pipes = GameObject.FindGameObjectsWithTag("pipes");
        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
        GameObject[] sscore = GameObject.FindGameObjectsWithTag("Score");
        for (int i = 0; i < sscore.Length; i++)
        {
            Destroy(sscore[i].gameObject);
        }

    }
    public void GameOver()
    {
        gameOver.SetActive(true);
        //playButton.SetActive(true);
        Menudid.SetActive(true);
        player.enabled = false;
        spawner.enabled = false;
        moveGround.enabled = false;
        did.enabled = true;
        test();
    }

        public void IncreaseScore()
        {
            score++;
            Score.text = score.ToString();
        if (score > highscore)
        {
            highscore = score;
        }
        //  ÕœÌÀ ⁄—÷ «·”ﬂÊ—
        UpdateUI();


        }
        void UpdateUI()
        {
        // ⁄—÷ «·”ﬂÊ— «·Õ«·Ì Ê«·”ﬂÊ— «·√⁄·Ï ›Ì Ê«ÃÂ… «·„” Œœ„
        
        HighScore.text = "" + highscore;
        }


        public void test()
        {

       
            GameObject[] pipes = GameObject.FindGameObjectsWithTag("pipes");
            for (int i = 0; i < pipes.Length; i++)
            {
            pipes[i].GetComponentInParent<Pipes>().enabled = false; 
             
            }

        }
        
        public void stopPlayer()
        {
        // pplayer.transform.position=ground.transform.position;
        player.transform.position = new Vector3(ground.transform.position.x, ground.transform.position.y + yOffset, player.transform.position.z);

        did.enabled=false;
        }



}
