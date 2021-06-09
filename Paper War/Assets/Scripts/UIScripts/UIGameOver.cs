using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIGameOver : MonoBehaviour
{

    public GameObject deadMessage;
    public GameObject scoreMessage;
    public GameObject pausebutton;

    // Start is called before the first frame update
    void Start()
    {
        deadMessage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Player").GetComponent<PlayerVariables>().playerHealth <= 0)
        {
            deadMessage.SetActive(true);
            scoreMessage.SetActive(true);
            pausebutton.GetComponent<Button>().enabled = false;
            Debug.Log("Endgame");
            Time.timeScale = 0;
        }
    }
}
