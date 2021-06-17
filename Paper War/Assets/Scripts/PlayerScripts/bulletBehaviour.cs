using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletBehaviour : MonoBehaviour
{
    private float xRange = 11;
    private float zRange = 8;
    void Start()
    {

    }

    void Update()
    {
        if (transform.position.x > xRange || transform.position.x < -xRange || transform.position.z > zRange || transform.position.z < -zRange)
        {
            //Debug.Log("peloamor");
            Destroy(gameObject, .2f);
        }
    }

    /* private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.CompareTag("Enemy"))
        {
            Debug.Log("eita");
        }
    }*/

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("eita");
            //Destroy(other.gameObject);
            if (other.GetComponent<EnemyHealth>() != null)
            {

                other.GetComponent<EnemyHealth>().enemyHP -= 1;

                Debug.Log(other.GetComponent<EnemyHealth>().enemyHP);
            }

            if (other.GetComponentInChildren<FlashMaterial>() != null)
            {
                other.GetComponentInChildren<FlashMaterial>().whiteChange = true;
                
            }

            Destroy(gameObject);
        }

    }
}
