using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundtrackController : MonoBehaviour
{

    public bool mute;

    // Start is called before the first frame update
    void Start()
    {
        //FindObjectOfType<AudioManager>().Play("Soundtrack");
    }

    // Update is called once per frame
    void Update()
    {
        if (mute == false)
        {
            gameObject.GetComponent<AudioSource>().enabled = true;
        }
        if (mute == true)
        {
            gameObject.GetComponent<AudioSource>().enabled = false;
        }
    }
}
