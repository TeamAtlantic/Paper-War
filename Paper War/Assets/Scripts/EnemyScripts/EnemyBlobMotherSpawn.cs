using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBlobMotherSpawn : MonoBehaviour
{

    public GameObject[] stuffToSpawn;
    public Vector3[] placeToSpawn;
    private int enemyHP;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemyHP = gameObject.GetComponent<EnemyHealth>().enemyHP;

        if (enemyHP <= 0)
        {
                Debug.Log("Sup?");
                    for (int i = 0; i < stuffToSpawn.Length; i++)
                    {
                        Instantiate(stuffToSpawn[i], transform.position + placeToSpawn[i], transform.rotation);
                        stuffToSpawn[i].transform.parent = null;
            }
        }
    }
}
