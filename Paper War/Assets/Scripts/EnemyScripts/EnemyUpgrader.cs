using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUpgrader : MonoBehaviour
{

    private GameObject blobSpawner;
    private int blobSpawnerCounter;

    public int levelUp1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        blobSpawner = GameObject.Find("BlobSpawner");
        blobSpawnerCounter = blobSpawner.GetComponent<EnemySpawner>().enemyCounter;

        if (blobSpawnerCounter > levelUp1)
        {
            GameObject.Find("Blob").GetComponent<EnemyFollow>().enemySpeed = 4;
            GameObject.Find("Blob").GetComponent<EnemyHealth>().enemyHP = 3;
            GameObject.Find("Blob").GetComponentInChildren<SpriteRenderer>().color = new Color(255,255,0,255);
        }
    }
}
