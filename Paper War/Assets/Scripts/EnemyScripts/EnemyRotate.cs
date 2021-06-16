using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotate : MonoBehaviour
{

    Transform target;
    public float turnSpeed;
    Vector3 wheteToLook;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            wheteToLook = target.position - gameObject.transform.position;
            wheteToLook.Normalize();
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(wheteToLook), turnSpeed * Time.deltaTime);
        }
    }
}
