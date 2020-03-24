using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject item; //Gameobjekt för att instantiata
    private Transform player;//Transform för att hitta spelarens position
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("player").transform;//hitta Transformens tag och då dens position
    }
    public void SpawnDroppedItem()
    {
        Vector2 playerPos = new Vector2(player.position.x + 2, player.position.y); //gör en vector för spelarens position genom att ta transformen på spelaren
        Instantiate(item, playerPos, Quaternion.identity);//skapar ett item på positionen som är ovan
    }
  
}
