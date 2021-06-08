using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPauseButton : MonoBehaviour
{

    public int isPlaying = 1;
    public GameObject pauseText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlaying >= 0)
        {
            Time.timeScale = 1;
            pauseText.SetActive(false);
        }

        if (isPlaying <= 0)
        {
            Time.timeScale = 0;
            pauseText.SetActive(true);
        }
    }

    public void PauseButton()
    {
        isPlaying *= -1;
    }
}
