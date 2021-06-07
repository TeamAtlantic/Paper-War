using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBouncing : MonoBehaviour
{
    public Rigidbody bouncerRb;
    public float bouncerSpeedX;
    public float bouncerSpeedY;

    public int bouncerHealth = 2;

    // Start is called before the first frame update
    void Start()
    {
        bouncerRb = GetComponent<Rigidbody>();

        bouncerSpeedX = Random.Range(1, 5);
        bouncerSpeedY = Random.Range(4, 7);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * bouncerSpeedX);
        transform.Translate(Vector3.up * Time.deltaTime * bouncerSpeedY);

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

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            bouncerSpeedY *= -1;
            bouncerSpeedX *= -1;

            bouncerHealth -= 1;
            if (bouncerHealth <= 0)
            {
                Destroy(gameObject);
            }

            GameObject.Find("Player").GetComponent<PlayerVariables>().playerHealth -= 1; 

        }
    }
}
