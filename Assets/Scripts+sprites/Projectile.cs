using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    public float damage = 5f;
    public float lifeTime;
    void Start()
    {
        Invoke("DestroyProjectile", lifeTime);
    }
    void Update()
    {
        transform.Translate(transform.up * speed * Time.deltaTime);
    }
    void DestroyProjectile()
    {
        Destroy(gameObject);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<healthscript>().TakeDamage(damage);
        Destroy(gameObject);
    }
}
