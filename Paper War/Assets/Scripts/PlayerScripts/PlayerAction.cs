using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;

    public float bulletForce = 25f;
    public float fireRate = 0.2f;
    private float nextFire = 0f;

    void Start()
    {
        
    }

    void Update()
    {
        
     Shoot();
        
    }

    void Shoot()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;

            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            rb.AddForce(firePoint.right * bulletForce, ForceMode.Impulse);
        }
    }
}
