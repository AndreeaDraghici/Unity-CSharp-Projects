using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerMover : MonoBehaviour
{
    public float spinSpeed = 90;
    public float direction = 1;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime*spinSpeed*direction);
    }
}
