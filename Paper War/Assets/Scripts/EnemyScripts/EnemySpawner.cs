using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public float timerToAction;
    private float timerReset;
    public float initialDelay;

    public GameObject enemyToSpawn;
    public GameObject dude;

    public int enemyCounter;
    private int spawnCounter;
    public int spawnCounterRate;
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
        initialDelay -= Time.deltaTime;

            if (initialDelay <= 0)
            {

                timerToAction -= Time.deltaTime;
                Debug.Log(spawnCounter);

                if (timerToAction <= 0)
                {

                    int cleber = Random.Range(0, placeToSpawn.Length);

                    dude = Instantiate(enemyToSpawn, placeToSpawn[cleber].position, Quaternion.identity);
                    dude.gameObject.name = enemyToSpawn.name;

                    timerToAction = timerReset;
                    spawnCounter += 1;
                    enemyCounter += 1;

                    if (spawnCounter >= spawnCounterRate)
                        {

                        spawnCounter = 0;
                            if (timerReset > 2)
                            {
                                timerReset -= spawnRateShortner;
                            }
                        }
                }

            }

    }
}
