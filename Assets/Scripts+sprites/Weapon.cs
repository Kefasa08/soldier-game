﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float offset;
    public GameObject projectile;
    public Transform shotPoint;
    public GameObject playerObject;
    private Collider2D WeaponColl;
   
    private float timeBtwShots;
    public float startTimebtwShots;




    private void Start()
    {
        WeaponColl = GetComponent<Collider2D>();
    }

    void Update()
    {
        if (gameObject.transform.parent == playerObject.transform)
        {
            Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);

            if (timeBtwShots <= 0)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    GameObject bullet = Instantiate(projectile, shotPoint.position, transform.rotation);
                    timeBtwShots = startTimebtwShots;
                   Camera.main.gameObject.GetComponent<ScreenShakeController>().StartShake(.25f, 1f);
                }
            }
            else
            {
                timeBtwShots -= Time.deltaTime;
            }
        }
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "player")
        {
            gameObject.transform.parent = playerObject.transform;
            transform.position = playerObject.transform.position;
            WeaponColl.enabled = false;
        }
    }
}
