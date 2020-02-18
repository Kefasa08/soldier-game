using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground_check : MonoBehaviour
{

    contorls player;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponentInParent<contorls>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.IsGrounded = true;
        player.inAirCollision = false;
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        player.IsGrounded = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
