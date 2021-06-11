using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody rb;

    public float horizontalInput;
    public float forwardInput;

    private float speed;
    private float turnSpeed;
    private float noBackwards = 0;

    void Start()
    {
        speed = GameObject.Find("Player").GetComponent<PlayerVariables>().playerSpeed;
        turnSpeed = GameObject.Find("Player").GetComponent<PlayerVariables>().playerTurnSpeed;
    }


    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //movement forward + no mov backwards
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

        if (forwardInput > 0)
            {
                transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
            } else if (forwardInput == -1)
        {
            Debug.Log("ta tendo re?");
            transform.Translate(Vector3.forward * Time.deltaTime * forwardInput * noBackwards);
        } 
     }
}
