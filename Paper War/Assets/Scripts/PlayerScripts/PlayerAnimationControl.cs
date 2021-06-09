using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationControl : MonoBehaviour
{

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<PlayerController>().horizontalInput > 0)
        {
            animator.SetBool("IsRotatingRight", true);
        }

        if (gameObject.GetComponent<PlayerController>().horizontalInput < 0)
        {
            animator.SetBool("IsRotatingLeft", true);
        }

        if (gameObject.GetComponent<PlayerController>().horizontalInput == 0)
        {
            animator.SetBool("IsRotatingRight", false);
            animator.SetBool("IsRotatingLeft", false);
        }
    }
}
