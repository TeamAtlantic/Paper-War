using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharpenerDamage : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        if (other.name == "PencilDamagePart")
        {
            Debug.Log("DAMAGE");
            other.GetComponentInParent<EnemyHealth>().enemyHP -= 100;
            //Destroy(other);

            if (other.GetComponentInParent<FlashMaterial>() != null)
            {
                other.GetComponentInParent<FlashMaterial>().whiteChange = true;

            }
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        
    }
}
