using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthscript : MonoBehaviour
{
    public Image healthBar;
    public float max_health = 100f;
    public float cur_health = 0f;
    [SerializeField]
    public float givehealth = 10f;
    void Start()
    {
        cur_health = max_health;
        SetHealthBar();
    }
    public void TakeDamage(float amount)
    {
        cur_health -= amount;
        SetHealthBar();
    }
    public void SetHealthBar()
    {
        float my_health = cur_health / max_health;
        healthBar.transform.localScale = new Vector3(Mathf.Clamp(my_health, 0f, 1f), healthBar.transform.localScale.y, healthBar.transform.localScale.z);
    }
    void Update()
    {
        if (cur_health <= 0f)
        {
            Destroy(gameObject);
        }
    }
    public void GiveHp(float amount)
    {
        cur_health += givehealth;
        SetHealthBar();
    }
}
