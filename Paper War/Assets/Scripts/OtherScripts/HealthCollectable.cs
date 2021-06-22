using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectable : MonoBehaviour
{

    public Rigidbody bouncerRb;
    public float bouncerSpeedX;
    public float bouncerSpeedY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            transform.Translate(Vector3.left * Time.deltaTime * bouncerSpeedX);
            transform.Translate(Vector3.forward * Time.deltaTime * bouncerSpeedY);


            int horizontalMax = GameObject.Find("Player").GetComponent<PlayerLooping>().horizontalMax;
            int horizontalMin = GameObject.Find("Player").GetComponent<PlayerLooping>().horizontalMin;
            int verticalMax = GameObject.Find("Player").GetComponent<PlayerLooping>().verticalMax;
            int verticalMin = GameObject.Find("Player").GetComponent<PlayerLooping>().verticalMin;

            if (transform.position.x <= horizontalMin)
            {
                bouncerSpeedX *= -1;

            }
            else if (transform.position.x >= horizontalMax)
            {
                bouncerSpeedX *= -1;
            }

            if (transform.position.z <= verticalMin)
            {
                bouncerSpeedY *= -1;

            }
            else if (transform.position.z >= verticalMax)
            {
                bouncerSpeedY *= -1;
            }
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        
            if (collision.gameObject.CompareTag("Player"))
            {
                    if (collision.gameObject.GetComponentInParent<PlayerVariables>().playerHealth < 3)
                        {
                             GameObject.Find("Player").GetComponent<PlayerVariables>().playerHealth += 1;
                        }
                    Destroy(gameObject);
                    //Debug.Log(GameObject.Find("Player").GetComponent<PlayerVariables>().playerHealth);
            }
            /*if (other.gameObject.CompareTag("Player"))
            {
                if (other.gameObject.GetComponent<PlayerVariables>().playerHealth < 3)
                {
                    other.GetComponent<PlayerVariables>().playerHealth += 1;
                    Destroy(gameObject);
                }
            }*/
        
    }
}
