using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;//hastigheten projektilen ska ha
    public float damage = 5f;//värdet för hur mycket damage den ska göra
    public float lifeTime;//tiden som projektilen ska finnas innan den förstörs
    void Start()
    {
        Invoke("DestroyProjectile", lifeTime);
    }
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
    void DestroyProjectile()
    {
        Destroy(gameObject);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            collision.gameObject.GetComponent<healthscript>().TakeDamage(damage);
            Destroy(gameObject);
        }
      
    }
   
}
