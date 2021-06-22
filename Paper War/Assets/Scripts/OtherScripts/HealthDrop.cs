using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDrop : MonoBehaviour
{

    private float score;
    private float reset;
    public float drop;

    public GameObject hp;

    public bool spawn;
    
    // Start is called before the first frame update
    void Start()
    {
        reset = drop;
    }

    // Update is called once per frame
    void Update()
    {



        score = GameObject.Find("Canvas").GetComponent<UIScore>().totalPoints;

        if (score == drop)
        {
            spawn = true;
            spawnHP();
        }
    }

    void spawnHP()
    {
        int horizontalMax = GameObject.Find("Player").GetComponent<PlayerLooping>().horizontalMax;
        int horizontalMin = GameObject.Find("Player").GetComponent<PlayerLooping>().horizontalMin;
        int verticalMax = GameObject.Find("Player").GetComponent<PlayerLooping>().verticalMax;
        int verticalMin = GameObject.Find("Player").GetComponent<PlayerLooping>().verticalMin;
        int horizontal = Random.Range(horizontalMin, horizontalMax);
        int vertical = Random.Range(verticalMin, verticalMax);

        Instantiate(hp, new Vector3(horizontal, 4, vertical), Quaternion.Euler(Random.Range(0.0f, 360.0f), Random.Range(0.0f, 360.0f), Random.Range(0.0f, 360.0f)));
        Debug.Log(score);
        drop += reset;
        spawn = false;
    }    
}
