using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroWinLoseScreens : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("GameScreen");
    }

    public void QuitApplication()
    {
        Application.Quit();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("WinScreen");
        }
    }
}
