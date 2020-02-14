using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public float health = 1f;
    public GameObject Bar;
    public GameObject BarSprite;
    public Rocket rocket;
    public GameObject spawner;
    void Start()
    {
        //rocket = GameObject.FindObjectOfType<Rocket>();
    }
    public void setHealthForAlienBullet()
    {
        health = health - 0.1f;
        
    }

    public void SetHealthForAliens()
    {
        health = health - 0.5f;
    }
    public void Update()
    {

        if (health <= 0.2f)
        {
            BarSprite.GetComponent<SpriteRenderer>().color = Color.green;
        }
        if (health <= 0.4f)
        {
            BarSprite.GetComponent<SpriteRenderer>().color = Color.white;
            if (health <= 0.1f)
            {
                rocket.rocketDead = true;
                Bar.SetActive(false);
                rocket.GameOver();
                spawner.SetActive(false);
            }
        }
        if (rocket.rocketDead == true)
        {
            Bar.SetActive(false);
            
        }
        Bar.transform.localScale = new Vector3(1f, health);
    }

    

    public void SetHealthForRocketDead()
    {
        health = 0;
    }


}
