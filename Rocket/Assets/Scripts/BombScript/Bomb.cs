using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Bomb : MonoBehaviour
{
    public Transform firePoint;
    public GameObject BombPrefab;
    public Text NoOfBullets;
    private float bullets;
    private float bulletForce = 15f;
    public AudioClip FireSound;

    void Start()
    {
        bullets = 40f;
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        bullets--;
        if (bullets >= 0)
        {
            AudioSource.PlayClipAtPoint(FireSound, transform.position);
            GameObject bullet = Instantiate(BombPrefab, firePoint.position, transform.rotation); ;
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
            NoOfBullets.text = bullets.ToString();
        }
    }
}
