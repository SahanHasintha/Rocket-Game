using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienBullet : MonoBehaviour
{
    public GameObject AlienbulletBlast;
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
            GameObject Blast = Instantiate(AlienbulletBlast, BlastPosition.position, transform.rotation);
            Destroy(Blast, 1f);
            Destroy(target.gameObject);
            Destroy(this.gameObject);
        }
        if (target.tag == "Rocket")
        {
            healthBar.setHealthForAlienBullet();
            Destroy(this.gameObject);
        }
    }
 
    
}
