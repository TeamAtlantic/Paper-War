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

    private GameObject playerProjectile;
    private Transform projectileSpawnPoint;

    float orientationControl = -1;

    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        speed = GameObject.Find("Player").GetComponent<PlayerVariables>().playerSpeed;
        turnSpeed = GameObject.Find("Player").GetComponent<PlayerVariables>().playerTurnSpeed;
        

        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * Time.deltaTime * speed * forwardInput * orientationControl);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
       
    }


}
