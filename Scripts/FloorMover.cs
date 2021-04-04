using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorMover : MonoBehaviour
{
    public GameObject floor;
    private bool elevatorMoving = false;
    public GameObject ExteriorWall;
    public GameObject player;


    // Update is called once per frame
    void FixedUpdate()
    { if (elevatorMoving == true)
        {
            if (floor.transform.position.y <= 9.9f)
            {
                floor.transform.position = new Vector3(floor.transform.position.x, floor.transform.position.y + 0.1f, floor.transform.position.z);
            }
            else
            {
                elevatorMoving = false;
                ExteriorWall.SetActive(false);
            }
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if(col.collider.gameObject.tag=="Player")
        {
            elevatorMoving = true;
        }
    }
}
