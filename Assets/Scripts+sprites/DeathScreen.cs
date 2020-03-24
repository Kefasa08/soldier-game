using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{

    public void ExitGame()// denhär koden är gjord för att stänga av spelet




    // Start is called before the first frame update
    void Start()
    {

    }


    public void ExitGame()   // denhär koden är gjord för att stänga av spelet

    {
        print("exit");
        Application.Quit();
    }


    public void Restartgame()// denhär koden är till för att flytta spelaren från en scen till en annan
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);

    public void Restartgame()         // denhär koden är till för att flytta spelaren från endscenen till tutorial scenen
    {

        SceneManager.LoadScene(3);

        print("funkar");
    }
}
