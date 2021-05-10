using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float fullHealth = 100f;

    void OnTriggerEnter(Collider other)
    {
        Pickup(other);
    }

    void Pickup(Collider player)
    {

        TankHealth healty = player.GetComponent<TankHealth>();
        healty.m_CurrentHealth = fullHealth;
        healty.SetHealthUI();

        Destroy(gameObject);
    }
}
