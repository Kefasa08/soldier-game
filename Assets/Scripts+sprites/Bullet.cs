using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    float damage = 5f;
    Rigidbody bullet;

    public float direction;
    void Start()
    {
        bullet = GetComponent<Rigidbody>();
        //bullet.velocity = new Vector3(100, 0, 0);
        print(transform.position);
    }

    public void Update()
    {
        Invoke("Kill", 0.7f);
        bullet.velocity = new Vector3(100 * direction, 0, 0);

    }
    private void OnTriggerEnter(Collider collision)
    {
        collision.gameObject.GetComponent<healthscript>().TakeDamage(damage);
        Destroy(gameObject);
    }
    void Kill()
    {
        Destroy(gameObject);
    }
}
