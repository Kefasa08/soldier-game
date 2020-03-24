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
        Invoke("DestroyProjectile", lifeTime); //Förstör efter den tid som lifetime har i värde
    }
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime); //ger dess transform en vector uppåt gånger hastigheten och Time.deltaTime
    }
    void DestroyProjectile()//metod för att förstöra projektilen
    {
        Destroy(gameObject);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")//om projektilen kolliderar med ett objekt som har taggen "Enemy"
        {
            collision.gameObject.GetComponent<healthscript>().TakeDamage(damage);//kallar på det kolliderade objektets script för HP och utför metoden för att den ska ta damage 
            Destroy(gameObject);//förstör objektet
        }
      
    }
   
}
