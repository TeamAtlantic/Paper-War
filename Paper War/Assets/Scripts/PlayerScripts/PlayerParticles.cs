using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerParticles : MonoBehaviour
{
    private float forwardInput;
    private SpriteRenderer flyingparticles;
    private AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        flyingparticles = GetComponent<SpriteRenderer>();
        flyingparticles.enabled = false;
        sound = GetComponent<AudioSource>();
        sound.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");

        if (forwardInput > 0.5)
        {
            flyingparticles.enabled = true;
            sound.enabled = true;
        }
        else if (forwardInput <= 0.5)
        {
            flyingparticles.enabled = false;
            sound.enabled = false;
        }
    }
}
