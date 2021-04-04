using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed = 0;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;

    public TextMeshProUGUI livesText;

    private Rigidbody rb;
    private int count;
    private float movementX;
    private float movementY;
    public GameObject exitRamp;
    private int lives = 3;
  

    // Start is called before the first frame update

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winTextObject.SetActive(false);
        
    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void SetCountText()
    {
        countText.text = "Score: " + count.ToString();
        if (count>=12)
        {
            //winTextObject.SetActive(true);
            exitRamp.SetActive(true);
        
        }
        if(count>40)
        {
            
        }
    }

    //private 
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);
        if (Input.GetKeyDown("space"))
        {
            Vector3 jump = new Vector3(0.0f, 300.0f, 0.0f);
            GetComponent<Rigidbody>().AddForce(jump);
        }


    }

    //private
    [System.Obsolete]
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Portal")
        {
            Application.LoadLevel("WinScene");
        }
        if(other.gameObject.tag=="Enemy")
        {
            transform.position = new Vector3(0.0f, 0.5f, 0.0f);
        }

        if(other.gameObject.tag=="EnemySpinner")
        {
            transform.position = new Vector3(0.0f, 0.5f, 0.0f);
        }

        if(other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
        } 
    }

    [System.Obsolete]
    void resetPlayer()
    {
        lives=lives-1;
        livesText.text = "Lives: " + lives.ToString();
        if (lives <= 0)
        {
            Application.LoadLevel("GameOverScene");
        }
        else
        {
            transform.position = new Vector3(0.0f, 0.5f, 0.0f);
            GetComponent<Rigidbody>().velocity = new Vector3(0.0f, 0.0f, 0.0f);
        }
    }
}

