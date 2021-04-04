using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMover : MonoBehaviour
{
    public float speed = 3;
    private Vector3 startingPosition;
    public float direction;
    public float distance;
    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(direction * Mathf.PingPong(Time.time * speed, distance) + startingPosition.x, transform.position.y, transform.position.z);
    }
}
