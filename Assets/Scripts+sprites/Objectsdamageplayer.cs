﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectsdamageplayer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "player")
        {
            Destroy(gameObject);
        }
    }
}
