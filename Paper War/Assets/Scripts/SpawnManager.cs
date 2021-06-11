using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;

    private float xRange = 11;
    private float zRange = 8;
    public float enemySpawnStart = 2;
    public float spawnRange = 2;
    public
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", enemySpawnStart, Random.Range(0, spawnRange));
    }

    void Update()
    {
        
    }

    void SpawnRandomEnemy()
    {
        int enemyIndex = Random.Range(0, enemyPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-xRange, xRange), 1, zRange);

        Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);
    }
}
