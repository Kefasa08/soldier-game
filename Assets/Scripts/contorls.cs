using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contorls : MonoBehaviour
{
    Rigidbody2D RB;
    [SerializeField]
    private bool IsGrounded;
    [SerializeField]
    Sprite Shouvle_Out;
    Sprite original_sprite;
    [SerializeField]
    SpriteRenderer SR;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        SR = GetComponent<SpriteRenderer>();
        original_sprite = SR.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            RB.velocity = new Vector3(5, RB.velocity.y, 0); 
        }

        if (Input.GetKey(KeyCode.A))
        {
            RB.velocity = new Vector3(-5, RB.velocity.y, 0);
        }

        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            RB.velocity = new Vector3(0, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.W) && IsGrounded==true) 
        {
            RB.velocity = new Vector3(RB.velocity.x, 7, 0);
            IsGrounded = false;
        }

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            SR.sprite = Shouvle_Out;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            SR.sprite = original_sprite;
        }


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        IsGrounded = true;
    }
}
