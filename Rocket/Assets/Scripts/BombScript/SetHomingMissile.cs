using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetHomingMissile : MonoBehaviour
{

    public Transform target;
    public float angleChangingSpeed;
    public float movementSpeed;
    Vector2 direction;
   


    void Update()
    {
        foreach(GameObject go in GameObject.FindGameObjectsWithTag("Meteor")){
             direction = go.transform.position - transform.position;
        }
        
        float rotateAmount = Vector3.Cross(direction, transform.up).z;
        GetComponent<Rigidbody2D>().angularVelocity = -angleChangingSpeed * rotateAmount;
        GetComponent<Rigidbody2D>().velocity = transform.up * movementSpeed;
    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "Meteor")
        {
            Destroy(target.gameObject, 0f);
            Destroy(this.gameObject);
        }
    }
}
