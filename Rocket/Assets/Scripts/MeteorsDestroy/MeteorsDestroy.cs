using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorsDestroy : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Meteor" || target.gameObject.tag == "RedBomb" || target.gameObject.tag=="AlienBullet" || target.gameObject.tag == "Aliens"|| target.gameObject.tag == "Tiles")
        {
            Destroy(target.gameObject);
        }
        
    }
    


}
