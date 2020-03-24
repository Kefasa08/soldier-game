using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    public float delay = 3f;//float för tiden granaten ska vänta innan den exploderar
    public float radius = 5f;//float för en radius som dess explosion har
    public float damage = 20f;//float för hur mycket skada den ska göra
    float countdown;

    public GameObject explosionEffect; //Gameobject för explosionens partikelsystem

    bool hasExploded = false; //för att se om granaten har exploderat
    void Start()
    {
        countdown = delay;//gör countdown till delayen man väljer
    }
    void Update()
    {
        countdown -= Time.deltaTime;//subtraherar countdown värdet med 1 varje sekund
        if(countdown <= 0f && !hasExploded)//kollar om countdown är mindre eller lika med 0 och om hasExploded inte har skett
        {
            Explode();//utför Explode metoden
            hasExploded = true;//säger att granaten har exploderat
        }
    }

    void Explode()//metod för vad som händer när granaten exploderar
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);//skapar partikelsystemet på granatens position med den rotation
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);//gör en array för allt som är inom dess radius när den exploderar

        foreach(Collider nearbyObject in colliders)//gör att koden som är innanför utförs på varje object som är nearbyObject
        {
            Rigidbody2D rb = nearbyObject.GetComponent<Rigidbody2D>();//Säger att alla object med Rigidbody är nearbyObject
           
            if(rb != null)
            {
               
            }

            healthscript dmg = nearbyObject.GetComponent<healthscript>();
            if (dmg != null)
            {
                dmg.TakeDamage(damage);//utför metoden för att objekten ska ta damage med värdet som damage variablen har
                Debug.Log("BOOM");
            }
        }

        Destroy(gameObject);
    }
}
