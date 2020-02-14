using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenTileSpawn : MonoBehaviour
{
    public GameObject Tile;
    private Rocket rocket;
    void Start()
    {
        rocket = GameObject.FindObjectOfType<Rocket>();
        StartCoroutine(SpawnTiles());
        StartCoroutine(SpawnTiles2());
    }

    void Update()
    {
        if (rocket.rocketDead)
        {
            StopAllCoroutines();
        }
    }

    IEnumerator SpawnTiles()
    {
        yield return new WaitForSeconds(5f);
        float x = Random.Range(-1.96f, 2.58f);
        float y = transform.position.y;
        Instantiate(Tile, new Vector3(x, y), transform.rotation);
        Instantiate(Tile, new Vector3(x - 1.46f, y), transform.rotation);
        Instantiate(Tile, new Vector3(x + 1.46f, y), transform.rotation);
        StartCoroutine(SpawnTiles());
    }

    IEnumerator SpawnTiles2()
    {
        yield return new WaitForSeconds(3f);
        float x = Random.Range(-1.96f, 2.58f);
        float y = transform.position.y;
        Instantiate(Tile, new Vector3(x, y), transform.rotation);
        Instantiate(Tile, new Vector3(x - 1.46f, y), transform.rotation);
        Instantiate(Tile, new Vector3(x + 1.46f, y), transform.rotation);
        Instantiate(Tile, new Vector3(x, y + 0.785f), transform.rotation);
        Instantiate(Tile, new Vector3(x - 1.46f, y + 0.785f), transform.rotation);
        Instantiate(Tile, new Vector3(x + 1.46f, y + 0.785f), transform.rotation);
        StartCoroutine(SpawnTiles2());
    }
}
