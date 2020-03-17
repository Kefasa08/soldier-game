﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    private static BackgroundController instance;

    public Transform target;

    private float startY;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        startY = transform.position.y;
    }
    void Update()
    {
        if (target != null)
        {
            transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
        }
    }
}
