using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invisibility : MonoBehaviour
{
    private SpriteRenderer character;
    private Color col;
    private float activationTime;
    private bool invisible;
    
    void Start()
    {
        character = GetComponent<SpriteRenderer>();
        activationTime = 0;
        invisible = false;
        col = character.color;
    }

    
    void Update()
    {
        activationTime += Time.deltaTime;
        if(invisible && activationTime >=3)
        {
            invisible = false;
            col.a= 1;
            character.color = col;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Invisible")
        {
            invisible = true;
            activationTime = 0;
            col.a = .2f;
            character.color = col;
            other.gameObject.SetActive(false);
        }
    }
}
