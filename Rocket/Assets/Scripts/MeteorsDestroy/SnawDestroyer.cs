using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnawDestroyer : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Snaw")
        {
            Destroy(target.gameObject);
        }

    }
}
