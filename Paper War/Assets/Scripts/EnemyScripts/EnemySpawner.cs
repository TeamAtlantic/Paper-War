using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public float timerToAction;
    private float timerReset;

    public GameObject enemyToSpawn;

    private int enemyCounter;
    public int enemyCounterRate;
    public float spawnRateShortner;

    public Transform[] placeToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        timerReset = timerToAction;
    }

    // Update is called once per frame
    void Update()
    {
        timerToAction -= Time.deltaTime;
        Debug.Log(enemyCounter);

        if (timerToAction <= 0)
        {

            int cleber = Random.Range(0, placeToSpawn.Length);

            Instantiate(enemyToSpawn, placeToSpawn[cleber].position, Quaternion.identity);

            timerToAction = timerReset;
            enemyCounter += 1;

            if (enemyCounter >= enemyCounterRate)
                {

                enemyCounter = 0;
                    if (timerReset > 2)
                    {
                        timerReset -= spawnRateShortner;
                    }
                }
        }
    }
}
