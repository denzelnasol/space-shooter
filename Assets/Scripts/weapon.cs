using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    float lastFired = 0f;
    float fireRate = 0.1f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Time.time > lastFired)
        {
            lastFired = Time.time + fireRate;
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Debug.Log("FIRED");
        }


        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Shoot();
        //}

    }
}
