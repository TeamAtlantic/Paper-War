using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeathEffect : MonoBehaviour
{

    public GameObject deathObject;

    public void Die()
    {
        Destroy(deathObject);
    }

}
