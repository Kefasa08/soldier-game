using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    public void ExitGame()
    {
        print("exit");
        Application.Quit();

    }

    public void Restartgame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        print("funkar");
    }

}
