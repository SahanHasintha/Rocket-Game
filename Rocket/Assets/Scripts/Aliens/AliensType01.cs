using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AliensType01 : MonoBehaviour
{

    public GameObject AlienType01Blast;
    public Transform BlastPosition;
    private HealthBar healthBar;

    void Start()
    {
        healthBar = GameObject.FindObjectOfType<HealthBar>();
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Bomb")
        {
            Destroy(this.gameObject);
            Destroy(target.gameObject);
            GameObject AlienType01 = Instantiate(AlienType01Blast, BlastPosition.position, transform.rotation);
            Destroy(AlienType01,1f);
        }
        else if (target.tag == "Rocket")
        {
            healthBar.SetHealthForAliens();
            Destroy(gameObject);
            GameObject AlienType01 = Instantiate(AlienType01Blast, BlastPosition.position, transform.rotation);
            Destroy(AlienType01, 1f);
        }
    }
}
