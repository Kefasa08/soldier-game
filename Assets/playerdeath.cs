using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerdeath : MonoBehaviour
{
    [SerializeField]
    GameObject player;

    void Update()
    {
        if (player == null)
        {
            print("aa");
            SceneManager.LoadScene(2);

        }
    }
}
