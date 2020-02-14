using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnawScript : MonoBehaviour
{
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(-80f*Time.deltaTime, 10f*Time.deltaTime);
    }
}
