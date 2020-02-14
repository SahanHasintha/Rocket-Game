using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Rocket;
    private float offset;
    // Start is called before the first frame update
    void Start()
    {
        Rocket = GameObject.Find("Rocket").transform;
        offset = transform.position.y - Rocket.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0, Rocket.position.y + offset , transform.position.z);
    }
}
