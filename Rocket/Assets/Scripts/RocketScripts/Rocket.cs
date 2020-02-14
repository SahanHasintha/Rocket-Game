using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Rocket : MonoBehaviour
{
    public Joystick joystick;
    private float yMove = 3F;
    public Rigidbody2D rb;
    public Vector3 birdRotation;
    public int score;
    public Text Scores,GameOverScore,GameOverHighScore,NewHighScoreMessage,GameWinScore,GameWinHighScore;
    public GameObject Meteor;
    public GameObject Gameover,GameWin;
    public GameObject Bounder,rocket,UI;
    public GameObject AlienCar,AlienBullet, AlienCar2;
    public GameObject Spawner;
    private HealthBar healthBar;
    

    public bool rocketDead;
    public bool gameWin;

    void Start()
    {
        //print(SceneManager.GetActiveScene().buildIndex + 1);
        score = 0;
        AlienBullet.SetActive(true);
        healthBar = GameObject.FindObjectOfType<HealthBar>();
        
    }
    
    void Update()
    {
        if (!rocketDead)
        {
            yMovement();
            xMovement();
        }
        if (!rocketDead)
        {
            setScore();
            WinGame();
        }
        if(rocketDead == true)
        {
            healthBar.SetHealthForRocketDead();
        }
    }

    void yMovement()
    {
        rb.velocity = new Vector3(0, yMove);
    }

    void xMovement() {
        if (joystick.Horizontal <= -0.2)
        {
            transform.Translate(-Time.deltaTime*4F,0,0,Space.Self);
            RotateLeft();
        }
        if (joystick.Horizontal == 0)
        {
            GoStraight();
        }
        if (joystick.Horizontal >= 0.2)
        {
            transform.Translate(Time.deltaTime*4F, 0, 0);
            RotateRight();
        }
    }
    void GoStraight()
    {
        transform.eulerAngles = new Vector3(0f, 0f, 0f); 
    }

    void RotateLeft()
    {
        birdRotation = new Vector3(0f, 0f, 30f);
        transform.eulerAngles = birdRotation;
    }

    void RotateRight()
    {
        birdRotation = new Vector3(0f, 0f, -30f);
        transform.eulerAngles = birdRotation;
    }
    
    void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "Meteor")
        {
            rocketDead = true;
            GameOver();

        }
        else if (target.gameObject.tag == "Bounds")
        {
            rocketDead = true;
            GameOver();

        }

    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag== "RedBomb")
        {
            //print("Collide");
            rocketDead = true;
            GameOver();
            Spawner.SetActive(false);
        }else if (target.gameObject.tag == "Tiles")
        {
            //print("Collide");
            rocketDead = true;
            GameOver();
            Spawner.SetActive(false);
        }
    }


    void setScore()
    {
        PlayerPrefs.SetInt("Score", score);
        Scores.text = PlayerPrefs.GetInt("Score").ToString();
        GameOverScore.text = PlayerPrefs.GetInt("Score").ToString();
        GameWinScore.text = PlayerPrefs.GetInt("Score").ToString();
        GameOverHighScore.text = PlayerPrefs.GetInt("HighScore",0).ToString();
        GameWinHighScore.text = PlayerPrefs.GetInt("HighScore",0).ToString();
        setHighScore();
    }
    void setHighScore()
    {
        if(score> PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
            GameOverHighScore.text = PlayerPrefs.GetInt("HighScore").ToString();
            GameWinHighScore.text = PlayerPrefs.GetInt("HighScore").ToString();
        }

    }

    public void GameOver()
    {
        Gameover.SetActive(true);
        publicDeactivates();
        
    }

    void WinGame()
    {
        if (score > 1)
        {
            PlayerPrefs.SetInt("levelReached", SceneManager.GetActiveScene().buildIndex);
            GameWin.SetActive(true);
            publicDeactivates();
            gameWin = true;
            AlienCar.SetActive(false);
            AlienBullet.SetActive(false);
            AlienCar2.SetActive(false);
            
            
        }
    }

    public void publicDeactivates()
    {
        rocket.SetActive(false);
        UI.SetActive(false);
        Bounder.SetActive(false);
        AlienCar.SetActive(false);
        AlienBullet.SetActive(false);
        AlienCar2.SetActive(false);
        
    }


}
