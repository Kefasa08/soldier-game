using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static CameraController instance;

    public Transform target;
    [Range(0, 50)]
    public float cameraOffset = 3;

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
        if(target != null)
        {
            transform.position = new Vector3(target.position.x, target.position.y + cameraOffset, transform.position.z);
        }
    }
}
