using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

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
        if(Vector2.Distance(transform.position, player.position) < 200f)
        {
            if (timeBtwShots == startTimebtwShots)
            {
                GameObject bullet = Instantiate(projectile, shotPoint.position, transform.rotation);

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
