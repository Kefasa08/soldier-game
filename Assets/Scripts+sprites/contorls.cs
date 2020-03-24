using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKey(KeyCode.D) && !inAirCollision)      // denhär koden gör så att karaktären rör sig frammot när man trycker på D förutom om man är i luften, den sätter även igong animationen när karaktären rör sig
        {
            RB.velocity = new Vector3(2, RB.velocity.y, 0);
            Anim.SetBool("Walking", true);
        }

        if (Input.GetKey(KeyCode.A) && !inAirCollision)     // denhär koden gör så att karaktären rör sig bakot när man trycker på A förutom om man är i luften, den sätter även igong animationen när karaktären rör sig
        {
            Anim.SetBool("Walking", true);
            RB.velocity = new Vector3(-2, RB.velocity.y, 0);

        }

        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))   // denhär koden är till för att stoppa walk animationen när karaktären slutar röra sig
        {
            Anim.SetBool("Walking", false);
            RB.velocity = new Vector3(0, RB.velocity.y, 0);

        }

        if (Input.GetKeyDown(KeyCode.W) && IsGrounded == true)     //denhär delen av koden gör så att man kan hoppa när man trycker på W och sätter igong animationen
        {
            Anim.SetTrigger("Jumping");
            RB.velocity = new Vector3(RB.velocity.x, 5, 0);
            Debug.Log("jump");                                       
        }
        
        if (transform.position.y<=-5)
        {
            SceneManager.LoadScene(2);
        }
    }

  

   /* private void OnCollisionEnter2D(Collision2D collision)
    {
        if (IsGrounded == false)
        {
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


    }*/
    public void FixedUpdate()       // denhär koden gör så att karaktären titar åt hollet man går mot
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
