using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKamikaze : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log(gameObject.name + " is dead!");   
            Destroy(gameObject);

            GameObject.Find("Player").GetComponent<PlayerVariables>().playerHealth -= 1;
        }
    }
}
