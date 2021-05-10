using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    public float newSpeed = 45f;

    private float waiting = 10f;
    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(Pickup(other));
    }

    IEnumerator Pickup(Collider player)
    {


        TankMovement speed = player.GetComponent<TankMovement>();
        speed.m_Speed = newSpeed;


        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        yield return new WaitForSeconds(waiting);

        speed.m_Speed = 12f;

        Destroy(gameObject);
    }
}
