using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minor : MonoBehaviour
{

   public GameObject minaExplotion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "player" )
        {
            StartCoroutine(DestroyObject(collision.gameObject));
        }

        IEnumerator DestroyObject(GameObject objectToDestroy)
        {
            yield return new WaitForSeconds(0f);
            Destroy(objectToDestroy);
            Instantiate(minaExplotion,transform.position, Quaternion.identity);
            Destroy(gameObject);
          
        }
    }

    

    // Update is called once per frame
    void Update()
    {
       
    }
}
