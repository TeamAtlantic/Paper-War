using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathMovement : MonoBehaviour
{

    public Transform[] points;
    public float speed;
    int current;

    // Start is called before the first frame update
    void Start()
    {
        current = 0;
        FindObjectOfType<AudioManager>().Play("PopSound");
    }

    // Update is called once per frame
    void Update()
    {

       if (transform.position != points[current].position)
        {
            transform.position = Vector3.MoveTowards(transform.position, points[current].position, speed * Time.deltaTime);
        }
       else
        {
            current = (current + 1) % points.Length;
        }
    }
}

