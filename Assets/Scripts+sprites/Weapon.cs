using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float offset;//float för en offset som ändrar vapnets rotation
    public GameObject projectile;//Objekt som är projektilen
    public Transform shotPoint;//transform för vart projektilen ska skapas från
    public GameObject playerObject;//objekt för spelaren
    private Collider2D WeaponColl;// collider för vapnet
   
    private float timeBtwShots;// float för att bestämma hur ofta man kan skjuta
    public float startTimebtwShots;




    private void Start()
    {
        WeaponColl = GetComponent<Collider2D>();
    }

    void Update()
    {
        if (gameObject.transform.parent == playerObject.transform)//Om vapnet är en child av spelaren så funkar koden under
        {
            Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;//subtraherar musens position med vapnets
            float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;//sätter dess rotation till differensen ovan på både x och y
            transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);

            if (timeBtwShots <= 0)//om värdet på hur ofta man kan skjuta är <= 0 
            {
                if (Input.GetMouseButtonDown(0))//om man trycker ned vänsterklick
                {
                    GameObject bullet = Instantiate(projectile, shotPoint.position, transform.rotation);//Gör objektet bullet till projektilen med shotpointens position och vapnets rotation
                    timeBtwShots = startTimebtwShots;// gör värdet på mellanrum mellan skotten till startTimebtwShots
                   Camera.main.gameObject.GetComponent<ScreenShakeController>().StartShake(.25f, 1f);//kallar på kamerans objekt och scriptet som får kameran att skaka
                }
            }
            else//annars
            {
                timeBtwShots -= Time.deltaTime;//räkna ner timern genom att subtrahera delayen med 1 varje sekund
            }
        }
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "player")//om vapnet kolliderar med "player"
        {
            gameObject.transform.parent = playerObject.transform;// gör vapnet till en child av playern
            transform.position = playerObject.transform.position;// sätter vapnets position till spelarens position
            WeaponColl.enabled = false;// sätter collider för vapnet till false
        }
    }
}
