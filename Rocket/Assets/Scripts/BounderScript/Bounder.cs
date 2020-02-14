using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounder : MonoBehaviour
{
    public float yBound;
    public Transform bomb;
    public GameObject bombBlast;

    void Update()
    {
        if (transform.localPosition.y <= yBound)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, 0, transform.localPosition.z);
        }
        transform.Translate(0, -Time.deltaTime*5f, 0);
    }

    void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "Bomb")
        {
            
            float lifeTime = 1f;
           
            Destroy(target.gameObject);
            GameObject blast=Instantiate(bombBlast, target.gameObject.transform.position, transform.rotation);
            Destroy(blast, lifeTime);
        }
    }

}
