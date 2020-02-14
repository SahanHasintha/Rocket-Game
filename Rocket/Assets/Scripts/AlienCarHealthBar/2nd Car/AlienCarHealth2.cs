using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienCarHealth2 : MonoBehaviour
{
    private HealthBarAlienCar2 healthBarAlienCar;


    void Start()
    {
        healthBarAlienCar = GameObject.FindObjectOfType<HealthBarAlienCar2>();
    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Bomb")
        {
            //print("Hit the car");
            healthBarAlienCar.setHealth();
            Destroy(target.gameObject);


        }
    }
}
