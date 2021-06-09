using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody rb;

    private float horizontalInput;
    private float forwardInput;

    private float speed;
    private float turnSpeed;

    void Start()
    {
        speed = GameObject.Find("Player").GetComponent<PlayerVariables>().playerSpeed;
        turnSpeed = GameObject.Find("Player").GetComponent<PlayerVariables>().playerTurnSpeed;
    }


    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        
        if (forwardInput > 0)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
        }       
    }

}
