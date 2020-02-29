using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    public float delay = 3f;
    public float radius = 5f;
    public float damage = 20f;
   

    public GameObject explosionEffect;

    float countdown;
    bool hasExploded = false;
    void Start()
    {
        countdown = delay;
    }
    void Update()
    {
        countdown -= Time.deltaTime;
        if(countdown <= 0f && !hasExploded)
        {
            Explode();
            hasExploded = true;
        }
    }

    void Explode()
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

        foreach(Collider nearbyObject in colliders)
        {
            Rigidbody2D rb = nearbyObject.GetComponent<Rigidbody2D>();
           
            if(rb != null)
            {
               
            }

            healthscript dmg = nearbyObject.GetComponent<healthscript>();
            if (dmg != null)
            {
                dmg.TakeDamage(damage);
                Debug.Log("BOOM");
            }
        }

        Destroy(gameObject);
    }
}
