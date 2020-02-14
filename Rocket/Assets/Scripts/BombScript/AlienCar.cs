using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienCar : MonoBehaviour
{
    public GameObject Target;
    private Rocket rocket;
    float speed = 10f;
    public GameObject AlienBullet;
    public Transform AlienBulletPosition;
    


    void Start()
    {
        rocket = GameObject.FindObjectOfType<Rocket>();
        StartCoroutine(SetBullet());
        AlienBullet.SetActive(true);
    }
    void Update()
    {
        Vector2 direction = Target.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion quaternion = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, quaternion, speed * Time.deltaTime);
        if (rocket.rocketDead)
        {
            StopAllCoroutines();
        }
    }

    IEnumerator SetBullet()
    {
        
            yield return new WaitForSeconds(1f);
            GameObject bullet = Instantiate(AlienBullet, AlienBulletPosition.position, transform.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            Vector2 direction = Target.transform.position - bullet.transform.position;
            rb.velocity = direction * 50f * Time.deltaTime;
            StartCoroutine(SetBullet());
        
    }

    
}
