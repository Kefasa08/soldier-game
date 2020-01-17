using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject item;
    private Transform player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player").transform;
    }
    void Update()
    {
        
    }
    public void SpawnDroppedItem()
    {
        Vector2 playerPos = new Vector2(player.position.x + 1.5f, player.position.y);
        Instantiate(item, playerPos, Quaternion.identity);
    }
}
