using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovmentTest : MonoBehaviour

    
{
    Rigidbody2D RB;
    Animator Anim;

    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetKey(KeyCode.D))
        {
            RB.AddForce(transform.forward * 2);
            Anim.SetBool("Walking", true);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Anim.SetBool("Walking", true);
            RB.AddForce(transform.forward * 2);

        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            Anim.SetBool("Walking", false);
            RB.velocity = new Vector3(0, 0, 0);

        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Anim.SetTrigger("Jumping");
            RB.velocity = new Vector3(RB.velocity.x, 5, 0);

        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
