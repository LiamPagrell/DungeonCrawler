using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform gunPoint1;
    public Transform gunPoint2;
    public float fireRate = 0.5f;




    public float ammo;

    float timer;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetMouseButton(0) && timer > fireRate && ammo > 0)
        {
            ammo--;

            Instantiate(projectilePrefab, gunPoint1.position, gunPoint1.rotation);



            //TODO: Create a seccond gunPoint and fire every other bullet from that location instead.

            timer = 0;
        }
        if (Input.GetMouseButton(1) && timer > fireRate && ammo > 0)
        {
            ammo--;

            Instantiate(projectilePrefab, gunPoint2.position, gunPoint2.rotation);





            timer = 0;
        }



    }
}


