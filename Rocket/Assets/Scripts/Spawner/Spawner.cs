using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject meteors;
    
    public float timeMin  ;
    public float timeMax ;
    public float timeMinForRedBomb;
        public float timeMaxForRedBomb;
    [SerializeField]
    private GameObject RedBomb;
    private Rocket rocket;
    void Start()
    {
        rocket = GameObject.FindObjectOfType<Rocket>();
        StartCoroutine(Spawnmeteor());
        StartCoroutine(SpawanRedBomb());
        
    }
    void Update()
    {
        if (rocket.rocketDead)
        {
            StopAllCoroutines();
        }
        if (rocket.gameWin)
        {
            StopAllCoroutines();
        }

    }

    IEnumerator Spawnmeteor()
    {
        
            yield return new WaitForSeconds(Random.Range(timeMin, timeMax));
            Instantiate(meteors, new Vector2(Random.Range(-2.17f, 5.65f), transform.position.y), transform.rotation);
            StartCoroutine(Spawnmeteor());
        
        
          
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Bomb")
        {
            Destroy(target.gameObject);
        }
    }

    IEnumerator SpawanRedBomb()
    {
        
            yield return new WaitForSeconds(Random.Range(1f, 2f));
            Instantiate(RedBomb, new Vector2(Random.Range(-2.17f, 5.65f), transform.position.y), Quaternion.identity);
            StartCoroutine(SpawanRedBomb());
        
    }
}
