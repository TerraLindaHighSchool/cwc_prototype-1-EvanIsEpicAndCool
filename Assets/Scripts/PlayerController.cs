using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //changeable floats
    public float SPEED = 20f;
    public float TURNSPEED = 45.0f;
    //var
    public float horizontalInput;
    public float forwardInput;
    
    void Start()
    {
        
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

       
        transform.Translate(Vector3.forward * Time.deltaTime * SPEED * forwardInput);
        transform.Rotate(Vector3.up, TURNSPEED * horizontalInput * Time.deltaTime);
    }
}
