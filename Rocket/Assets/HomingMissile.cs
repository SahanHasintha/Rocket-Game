using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomingMissile : MonoBehaviour
{

    public GameObject missile;
    public Transform BombPosition;
    public float numberOfHomingMissile;
    public Text HomingMissileText;
    public AudioClip HomingMissileSounds;
    
    public void InstantiateMissile()
    {
        if (numberOfHomingMissile > 0)
        {
            AudioSource.PlayClipAtPoint(HomingMissileSounds, transform.position);
            Instantiate(missile, BombPosition.position, transform.rotation);
            HomingMissileText.text = "0";
            numberOfHomingMissile--;
        }
        
        HomingMissileText.text = numberOfHomingMissile.ToString();
    }
}
