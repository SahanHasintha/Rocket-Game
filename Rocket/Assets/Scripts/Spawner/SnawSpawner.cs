using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnawSpawner : MonoBehaviour
{
    public GameObject Snaw;
    private Rocket rocket;
    public float timeMin;
    public float timeMax;
    void Start()
    {
        rocket = GameObject.FindObjectOfType<Rocket>();
        StartCoroutine(Spawnmeteor());
    }
    IEnumerator Spawnmeteor()
    {
        if (!rocket.rocketDead || rocket.gameWin)
        {
            yield return new WaitForSeconds(Random.Range(timeMin, timeMax));
            GameObject snaw=Instantiate(Snaw, new Vector2(Random.Range(-8.4f, 16.0f), transform.position.y), Quaternion.identity);
            
            StartCoroutine(Spawnmeteor());
        }

    }
}
