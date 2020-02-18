using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "player")
        {
            StartCoroutine(DestroyObject(collision.gameObject));
        }

        IEnumerator DestroyObject(GameObject objectToDestroy)
        {
            yield return new WaitForSeconds(1);
            Destroy(objectToDestroy);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
