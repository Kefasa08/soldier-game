using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyshootingAI : MonoBehaviour
{
    public GameObject projectile;
    public Transform shotPoint;
    public Transform player;

    public float range = 10f;
    private float timeBtwShots;
    public float startTimebtwShots;
  
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player").transform;
    }

    void Update()
    {
        if(Vector2.Distance(transform.position, player.position) < range)
        {
          
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
