using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed = 0.55f;
    public Vector2 pointA, pointB;

    // Start is called before the first frame update
    void Start()
    {
        // pointA = new Vector3(-6, 1, 12.75f);
        // pointB = new Vector3(6, 1, 12.75f);
    }

    // Update is called once per frame
    void Update()
    {
        float time = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector2.Lerp(pointA, pointB, time);
    }
}
