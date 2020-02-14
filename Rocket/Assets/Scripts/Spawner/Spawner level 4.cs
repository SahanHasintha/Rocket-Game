using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerLevel4 : MonoBehaviour
{
    public GameObject meteors;
    private Rocket rocket;
    private float timeMin = 2f;
    private float timeMax = 3f;
    [SerializeField]
    private GameObject RedBomb;
    void Start()
    {
        rocket = GameObject.FindObjectOfType<Rocket>();
        StartCoroutine(Spawnmeteor());
        InvokeRepeating("CreateNewRedBomb", 3f, Random.Range(timeMin, timeMax));
    }

    IEnumerator Spawnmeteor()
    {
        if (!rocket.rocketDead)
        {
            if (!rocket.gameWin)
            {
                yield return new WaitForSeconds(Random.Range(timeMin, timeMax));
                Instantiate(meteors, new Vector2(Random.Range(-1f, 3.8f), transform.position.y), Quaternion.identity);
                StartCoroutine(Spawnmeteor());
            }
        }
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Bomb")
        {
            Destroy(target.gameObject);
        }
    }

    void CreateNewRedBomb()
    {
        if (!rocket.rocketDead)
        {
            GameObject redBomb = Instantiate(RedBomb, new Vector2(Random.Range(-2.17f, 5.65f), transform.position.y), Quaternion.identity);


        }
    }
}
