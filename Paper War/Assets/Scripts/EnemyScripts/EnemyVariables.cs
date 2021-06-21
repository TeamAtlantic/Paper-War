using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVariables : MonoBehaviour
{

    public int enemyHealth;
    public int enemySpeed;
    public int enemyRotationSpeed;
    public Color color;

    private int blobCounter;
    private int bouncerCounter;
    private int spiralerCounter;
    private int blobMotherCounter;

    public int[] levelEnemy;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        BlobManagement();
        

    }

    public void BlobManagement()
    {
        blobCounter = GameObject.Find("BlobSpawner").GetComponent<EnemySpawner>().enemyCounter;
        
        if (blobCounter >= levelEnemy[0])
        {
            enemyHealth = 5;
            enemySpeed = 4;
            color = new Color(255, 255, 0, 255);
        }
    }

}
