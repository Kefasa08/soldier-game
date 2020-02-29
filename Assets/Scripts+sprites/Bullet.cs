using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    float damage = 5f;
    Rigidbody2D bullet;

    public float direction;
    void Start()
    {
        bullet = GetComponent<Rigidbody2D>();
        //bullet.velocity = new Vector3(100, 0, 0);
        print(transform.position);
    }

    public void Update()
    {
       // Invoke("Kill", 0.7f);
        //bullet.velocity = new Vector3(100 * direction, 0, 0);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<healthscript>().TakeDamage(damage);
        Destroy(gameObject);
    }
    void Kill()
    {
        Destroy(gameObject);
    }
}
