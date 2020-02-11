using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contorls : MonoBehaviour
{
    Rigidbody2D RB;
    [SerializeField]
    Sprite Shouvle_Out;
    Sprite original_sprite;
    Animator Anim;
    public bool IsGrounded;
    public bool inAirCollision;
    public bool DigAnim = false;
    public bool facingRight = true;
    public float moveInput;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        Anim = GetComponent<Animator>();
        //original_sprite = SR.sprite;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.D) && !inAirCollision)
        {
            RB.velocity = new Vector3(2, RB.velocity.y, 0);
            Anim.SetBool("Walking", true);
        }

        if (Input.GetKey(KeyCode.A) && !inAirCollision)
        {
            Debug.Log(":)");

            Anim.SetBool("Walking", true);
            RB.velocity = new Vector3(-2, RB.velocity.y, 0);
            //RB.velocity = Vector3.zero;

        }

        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            Anim.SetBool("Walking", false);
            RB.velocity = new Vector3(0, 0, 0);

        }

        if (Input.GetKeyDown(KeyCode.W) && IsGrounded == true)
        {
            Anim.SetTrigger("Jumping");
            RB.velocity = new Vector3(RB.velocity.x, 5, 0);

        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            // SR.sprite = Shouvle_Out;
            if (Anim)
            {
                Debug.Log("ja");


            }
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {

        }
       

    }

  

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (IsGrounded == false)
        {
            Debug.Log("hej");
            inAirCollision = true;
            RB.velocity = new Vector3(0, RB.velocity.y, 0);
        }

    }
    void OnTriggerStay2D(Collider2D Trigger)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            if (Trigger.tag == "dig")
            {
                Anim.SetBool("Walking", false);
                Anim.SetTrigger("Digging");
                StartCoroutine(DestroyObject(Trigger.gameObject));
              
            }
            else if (Trigger.tag != "dig")
            {

            }
        }



    }

    IEnumerator DestroyObject (GameObject objectToDestroy)
    {
        yield return new WaitForSeconds(1);
        Destroy(objectToDestroy);
    }


    private void OnTrigger(Collider2D Trigger)
    {


    }
    public void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        //Debug.Log(moveInput);
        //RB.velocity = new Vector3(moveInput * speed, RB.velocity.y, 0);

        if (facingRight == false && moveInput > 0)
        {
            Flip();
        }
        else if (facingRight == true && moveInput < 0)
        {
            Flip();
        }
       // RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.left);
       // Debug.DrawRay(transform.position, Vector2.left * 100, Color.magenta);

    }
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
