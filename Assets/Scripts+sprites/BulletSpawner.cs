using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public Transform prefab;
    public float secondsBetweenSpawn = 0.5f;
    void Start()
    {

    }
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Bullet current = Instantiate(prefab, transform.position, Quaternion.identity).GetComponent<Bullet>();
            current.direction = transform.parent.parent.localScale.x * -1;

        }

    }
}
