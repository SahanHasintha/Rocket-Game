using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarAlienCar : MonoBehaviour
{
    public GameObject Bar;
    float healthOfAlienCar = 1f;
    public GameObject AlienCar;
    public GameObject Blast;
    public Transform position01;
    public Transform position02;
    public Transform position03;
    private Rocket rocket;
    public AudioClip AlienCarBlastSound;

    void Start()
    {
        rocket = GameObject.FindObjectOfType<Rocket>();
    }
    public void setHealth()
    {
        healthOfAlienCar -= 0.1f;
        Bar.transform.localScale = new Vector3(healthOfAlienCar, 1f);

        if (healthOfAlienCar < 0.1f)
        {
            GameObject Blast1 = Instantiate(Blast, position01.position, transform.rotation);
            AudioSource.PlayClipAtPoint(AlienCarBlastSound, transform.position);
            Destroy(Blast1, 0.5f);
            GameObject Blast2 = Instantiate(Blast, position02.position, transform.rotation);
            AudioSource.PlayClipAtPoint(AlienCarBlastSound, transform.position);
            Destroy(Blast2, 0.5f);
            GameObject Blast3 = Instantiate(Blast, position03.position, transform.rotation);
            AudioSource.PlayClipAtPoint(AlienCarBlastSound, transform.position);
            Destroy(Blast3, 0.5f);
            Destroy(AlienCar);
            //rocket.rocketDead = true;
        }
    }

   
}
