using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public GameObject Blast;
    public Transform BlastPosition;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(0, -Time.deltaTime * 4f, 0);
        
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "Bomb")
        {
           GameObject blast= Instantiate(Blast, BlastPosition.position, transform.rotation);
            Destroy(target.gameObject);
            Destroy(blast, 1f);
            Destroy(this.gameObject);
        }
    }
}
