using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyshootingAI : MonoBehaviour
{
    public GameObject projectile;// objekt för projektil
    public Transform shotPoint;//transform för vart projektilen ska skjutas från
    public Transform player;//transform för spelarens position

    public float range = 10f;//värde för distans som fienden ska ha
    private float timeBtwShots;// float för att bestämma hur ofta man kan skjuta
    public float startTimebtwShots;
  
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player").transform;//gör Transformen "player" till spelarens position
    }

    void Update()
    {
        if(Vector2.Distance(transform.position, player.position) < range)//om fiendens position till spelaren är mindre än range
        {
          
            if (timeBtwShots <= 0)//om värdet på hur ofta man kan skjuta är <= 0 
            {
                GameObject bullet = Instantiate(projectile, shotPoint.position, transform.rotation);//Gör objektet bullet till projektilen med shotpointens position och vapnets rotation
                timeBtwShots = startTimebtwShots;// gör värdet på mellanrum mellan skotten till startTimebtwShots
            }
            else
            {
                timeBtwShots -= Time.deltaTime;//räkna ner timern genom att subtrahera delayen med 1 varje sekund
            }

          
        }
    }
}
