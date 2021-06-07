using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    public GameObject playerProjectile;
    public GameObject theo;
    public Transform projectileSpawnPoint;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            theo = Instantiate(playerProjectile, projectileSpawnPoint.position, playerProjectile.transform.rotation);
            //theo.transform.SetParent(transform);
        }
    }
}
