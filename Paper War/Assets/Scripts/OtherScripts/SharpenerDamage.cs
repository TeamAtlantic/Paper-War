using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharpenerDamage : MonoBehaviour
{

    public void OnTriggerStay(Collider other)
    {
        if (other.name == "PencilDamagePart")
        {
            Debug.Log("DAMAGE");
            //Destroy(other);
        }
    }
}
