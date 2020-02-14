using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienCarHealth : MonoBehaviour
{
    private HealthBarAlienCar healthBarAlienCar;
    

    void Start()
    {
        healthBarAlienCar = GameObject.FindObjectOfType<HealthBarAlienCar>();
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
