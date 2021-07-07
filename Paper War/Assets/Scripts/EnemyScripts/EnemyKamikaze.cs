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
            //  Debug.Log(gameObject.name + " is dead!");

            gameObject.GetComponent<EnemyHealth>().enemyHP -= 1;
            //Destroy(gameObject);

            GameObject.Find("Player").GetComponent<PlayerVariables>().playerHealth -= 1;
            GameObject.Find("playerModel").GetComponent<PlayerMaterialFlash>().whiteChange = true;

            FindObjectOfType<AudioManager>().Play("PlaneHit");

        }
    }
}
