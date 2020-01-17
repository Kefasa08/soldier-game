using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurt_solder : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "player" && Input.GetKeyDown(KeyCode.E))
        {
            //Destroy(gameObject);
        
        }
    }
}
