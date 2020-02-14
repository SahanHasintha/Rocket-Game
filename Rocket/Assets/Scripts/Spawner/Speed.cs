using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    public AudioClip BlastSound;
    private Rocket rocket;
    public Rigidbody2D rb;
    public GameObject blast;
    public Transform blastPosition;

    void Start()
    {
        rocket = GameObject.FindObjectOfType<Rocket>();
        rb = GetComponent<Rigidbody2D>();
       
    }

    void Update()
    {
        rb.velocity = new Vector3(0,-10f, 0);
      
    }

    void OnCollisionEnter2D(Collision2D target)
    {
        
        if (target.gameObject.tag == "Bomb")
        {
            if (!rocket.rocketDead)
            {
                rocket.score++;
                Destroy(target.gameObject);
                Destroy(this.gameObject);
                SetBlast();
            }
            
        }
    }
    

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "HomingMissile")
        {
            rocket.score++;
            Destroy(target.gameObject);
            Destroy(this.gameObject);
            SetBlast();

        }

    }

    void SetBlast()
    {
        AudioSource.PlayClipAtPoint(BlastSound, transform.position);
        float lifeTime = 1f;
        GameObject Blast=Instantiate(blast, blastPosition.position, transform.rotation);
        Destroy(Blast, lifeTime);
    }
   
}
