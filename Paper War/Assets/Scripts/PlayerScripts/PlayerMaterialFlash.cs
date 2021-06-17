using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMaterialFlash : MonoBehaviour
{

    private Material matWhite;
    private Material matDefault;
    Renderer sr;
    Material srGun;
    public bool whiteChange;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<Renderer>();
        matWhite = Resources.Load("FlashDamage", typeof(Material)) as Material;
        matDefault = sr.material;

    }

    // Update is called once per frame
    void Update()
    {
        if (whiteChange == true)
        {
            sr.material = matWhite;
            Debug.Log(sr);
            Invoke("ResetMaterial", .1f);
        }
    }

    void ResetMaterial()
    {
        sr.material = matDefault;
        whiteChange = false;
        Debug.Log("Cleito");
    }
}
