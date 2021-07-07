using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPauseButton : MonoBehaviour
{

    public int isPlaying = 1;
    public GameObject pauseText;
    public Sprite pauseSprite;
    public Sprite playSprite;

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
            gameObject.GetComponent<Image>().sprite = pauseSprite;
        }

        if (isPlaying <= 0)
        {
            Time.timeScale = 0;
            pauseText.SetActive(true);
            gameObject.GetComponent<Image>().sprite = playSprite;
        }
    }

    public void PauseButton()
    {
        isPlaying *= -1;
        FindObjectOfType<AudioManager>().Play("PauseSound");
    }
}
