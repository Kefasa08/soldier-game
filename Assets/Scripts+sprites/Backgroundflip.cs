using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backgroundflip : MonoBehaviour
{
    public bool facingRight = true;
    public float moveInput;
    public void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");

        if (facingRight == false && moveInput > 0)
        {
            Flip();
        }
        else if (facingRight == true && moveInput < 0)
        {
            Flip();
        }

    }
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
