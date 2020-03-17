using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeaponRotator : MonoBehaviour
{
    public Transform player;
    public float range = 10f;
    public float offset = -90;
    public GameObject projectile;
    public Transform shotPoint;

    private float timeBtwShots;
    public float startTimebtwShots;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player").transform;
    }

   
    void Update()
    {
        if (Vector2.Distance(transform.position, player.position) < range)
        {
            Vector3 difference = player.position - transform.position;
            float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);

            if (timeBtwShots <= 0)
            {
                GameObject bullet = Instantiate(projectile, shotPoint.position, transform.rotation);
                timeBtwShots = startTimebtwShots;
            }
            else
            {
                timeBtwShots -= Time.deltaTime;
            }
        }
    }
}
