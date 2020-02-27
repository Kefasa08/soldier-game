using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camlock : MonoBehaviour
{
    public Transform player = null;
    void Update()
    {
        transform.position = new Vector3(player.position.x, 0.8f, -10);
    }
}
