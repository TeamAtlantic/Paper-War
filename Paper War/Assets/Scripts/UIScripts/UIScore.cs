using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScore : MonoBehaviour
{

    public Text scoreCounter;
    public Text highScoreCounter;


    public int timer;
    public int enemyPoints;
    public int totalPoints;

    // Start is called before the first frame update
    void Start()
    {
        highScoreCounter.text = "Highscore: " + PlayerPrefs.GetInt("highscore", totalPoints).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Player").GetComponent<PlayerVariables>().playerHealth >= 1)
        {
            timer += (int)(Time.deltaTime * 100);

            totalPoints = timer + enemyPoints;

            scoreCounter.text = "Your Score Was: " + totalPoints.ToString();
            //highScoreCounter.text = "Cleber";

        }


        if (GameObject.Find("Player").GetComponent<PlayerVariables>().playerHealth <= 0)
        {
            if (totalPoints > PlayerPrefs.GetInt("highscore"))
            {
                PlayerPrefs.SetInt("highscore", totalPoints);
                //highScoreCounter.text = totalPoints.ToString();
                highScoreCounter.text = "New Record!";
            }
        }
    }
}
