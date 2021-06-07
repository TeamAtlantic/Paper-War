using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    private Rigidbody projectileRb;
    private float projectileSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        projectileRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //projectileRb.AddForce(Vector3.forward * projectileSpeed, ForceMode.Impulse);
        //projectileRb.velocity = transform.right * -projectileSpeed;
        transform.Translate(Vector3.left * Time.deltaTime * projectileSpeed);


        //Destroy(gameObject, 1);
    }
}
