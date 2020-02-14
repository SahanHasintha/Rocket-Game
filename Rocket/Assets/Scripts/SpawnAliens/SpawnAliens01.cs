using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAliens01 : MonoBehaviour
{
   
    public GameObject Alien01;
    int count=0;
    private Rocket rocket;

    
    void Start()
    {
        InvokeRepeating("SpawnAlienTime01",1f, 0.1f);
        rocket = GameObject.FindObjectOfType<Rocket>();
    }
    void Update()
    {
        if (rocket.rocketDead)
        {
            CancelInvoke();
        }
        if (rocket.gameWin)
        {
            CancelInvoke();
        }
    }

    public void SpawnAlienTime01()
    {
        count++;
        
        Instantiate(Alien01, new Vector2(Random.Range(-2.17f, 5.65f), transform.position.y), transform.rotation);
        
        if (count >= 5)
        {
            CancelInvoke();
            InvokeRepeating("SpawnAlienTime02", 3f, 0.1f);
        }
    }
    public void SpawnAlienTime02()
    {
        count++;
        
        Instantiate(Alien01, new Vector2(Random.Range(-2.17f, 5.65f), transform.position.y), transform.rotation);

        if (count >= 15)
        {
            CancelInvoke();
            InvokeRepeating("SpawnAlienTime03", 3f, 0.1f);
        }
    }

    public void SpawnAlienTime03()
    {
        count++;
        print(count);
        Instantiate(Alien01, new Vector2(Random.Range(-2.17f, 5.65f), transform.position.y), transform.rotation);

        if (count >= 20)
        {
            CancelInvoke();
            InvokeRepeating("SpawnAlienTime04", 4f, 0.1f);
        }
    }

    public void SpawnAlienTime04()
    {
        count++;
        print(count);
        Instantiate(Alien01, new Vector2(Random.Range(-2.17f, 5.65f), transform.position.y), transform.rotation);
        
        if (count >= 20)
        {
            CancelInvoke();
            InvokeRepeating("SpawnAlienTime05", 4f, 0.1f);
        }
    }

    public void SpawnAlienTime05()
    {
        count++;
        print(count);
        Instantiate(Alien01, new Vector2(Random.Range(-2.17f, 5.65f), transform.position.y), transform.rotation);

        if (count >= 31)
        {
            CancelInvoke();
            InvokeRepeating("SpawnAlienTime06", 3f, 0.1f);
        }
    }
    public void SpawnAlienTime06()
    {
        count++;
        print(count);
        Instantiate(Alien01, new Vector2(Random.Range(-2.17f, 5.65f), transform.position.y), transform.rotation);

        if (count >= 41)
        {
            CancelInvoke();
            InvokeRepeating("SpawnAlienTime07", 3f, 0.1f);
        }
    }
    public void SpawnAlienTime07()
    {
        count++;
        print(count);
        Instantiate(Alien01, new Vector2(Random.Range(-2.17f, 5.65f), transform.position.y), transform.rotation);

        if (count >= 46)
        {
            CancelInvoke();
            InvokeRepeating("SpawnAlienTime08", 5f, 0.1f);
        }
    }
    public void SpawnAlienTime08()
    {
        count++;
        print(count);
        Instantiate(Alien01, new Vector2(Random.Range(-2.17f, 5.65f), transform.position.y), transform.rotation);

        if (count >= 55)
        {
            CancelInvoke();
            InvokeRepeating("SpawnAlienTime09", 3f, 0.1f);
        }
    }
    public void SpawnAlienTime09()
    {
        count++;
        print(count);
        Instantiate(Alien01, new Vector2(Random.Range(-2.17f, 5.65f), transform.position.y), transform.rotation);

        if (count >= 60)
        {
            CancelInvoke();
            InvokeRepeating("SpawnAlienTime10", 3f, 0.1f);
        }
    }
    public void SpawnAlienTime10()
    {
        count++;
        print(count);
        Instantiate(Alien01, new Vector2(Random.Range(-2.17f, 5.65f), transform.position.y), transform.rotation);

        if (count >= 67)
        {
            CancelInvoke();
           
        }
    }
}
