using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLooping : MonoBehaviour
{
    public Transform playerTransform;

    public int horizontalMin;
    public int horizontalMax;


    public int verticalMin;
    public int verticalMax;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = gameObject.GetComponentInChildren<Transform>();   
    }

    // Update is called once per frame
    void Update()
    {
      if (playerTransform.position.x <= horizontalMin)
        {
            playerTransform.position = new Vector3(horizontalMax, playerTransform.position.y, playerTransform.position.z);

        } else if (playerTransform.position.x >= horizontalMax)
            {
                playerTransform.position = new Vector3(horizontalMin, playerTransform.position.y, playerTransform.position.z);
            }

        if (playerTransform.position.z <= verticalMin)
        {
            playerTransform.position = new Vector3(playerTransform.position.x, playerTransform.position.y, verticalMax);

        }
        else if (playerTransform.position.z >= verticalMax)
        {
            playerTransform.position = new Vector3(horizontalMin, playerTransform.position.y, verticalMin);
        }
    }
}
