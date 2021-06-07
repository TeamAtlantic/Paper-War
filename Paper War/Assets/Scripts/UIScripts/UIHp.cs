using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHp : MonoBehaviour
{

    private Image healthBar;
    public Sprite[] healthSprite;

    public int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponentInChildren<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        currentHealth = GameObject.Find("Player").GetComponent<PlayerVariables>().playerHealth;

        if (currentHealth >= 3)
        {
            healthBar.sprite = healthSprite[3];
        }

        if (currentHealth == 2)
        {
            healthBar.sprite = healthSprite[2];
        }

        if (currentHealth == 1)
        {
            healthBar.sprite = healthSprite[1];
        }

        if (currentHealth == 0)
        {
            healthBar.sprite = healthSprite[0];
        }
    }
}
