using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallRespawn : MonoBehaviour
{

    private Vector3 initialPos;
    public float timeToRespawn;
    private float timerConstant;

    // Start is called before the first frame update
    void Start()
    {
        initialPos = gameObject.transform.position;
        timerConstant = timeToRespawn;
    }

    // Update is called once per frame
    void Update()
    {

        if (gameObject.transform.position.y <= -1)
        {
            timeToRespawn -= Time.deltaTime;

            if (timeToRespawn <= 0)
            {
                gameObject.transform.position = initialPos;
                timeToRespawn = timerConstant;
                gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
        }
    }
}
