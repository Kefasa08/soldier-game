using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyshootingAI : MonoBehaviour
{
    public GameObject projectile;
    public Transform shotPoint;
    public Transform player;

    private float timeBtwShots;
    public float startTimebtwShots;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player").transform;
    }

    void Update()
    {
        if(Vector2.Distance(transform.position, player.position) < 10f)
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        
    }
}
