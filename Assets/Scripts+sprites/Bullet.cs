using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed; //variabel för hastigheten kulan ska färdas i
    public float lifeTime; //tiden för hur snabbt den ska förstöras efter kulan har instantiatats
    void Start()
    {
        Invoke("DestroyProjectile", lifeTime); //Förstör kulan efter den tid som lifetime har i värde
    }
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
    void DestroyProjectile()//metod för att förstöra objektet
    {
        Destroy(gameObject); 
    }
   
}
