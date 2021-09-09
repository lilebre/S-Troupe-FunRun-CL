using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int heartsOnScreen;

    public Image[] hearts;
    public Sprite heartFull;
    public Sprite heartBlank;

    public GameObject gotHitScreen;

    public AudioSource audioS;

    private void Start()
    {
        audioS = GetComponent<AudioSource>();
    }

    void Update()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (health > heartsOnScreen)
            {
                health = heartsOnScreen;
            }

            if (i < health)
            {
                hearts[i].sprite = heartFull;
            } else
            {
                hearts[i].sprite = heartBlank;
            }

            if (i < heartsOnScreen) { 
                hearts[i].enabled = true;
            } else
            {
                hearts[i].enabled = false;
            }

            if(gotHitScreen != null)
            {
                if (gotHitScreen.GetComponent<Image>().color.a > 0)
                {
                    var color = gotHitScreen.GetComponent<Image>().color;
                    color.a -= 0.001f;

                    gotHitScreen.GetComponent<Image>().color = color;
                }
            }

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle") {
            health--;

            collision.gameObject.SetActive(false);

            if (health <= 0)
            {
                SceneManager.LoadScene("GameOverScene");
            }

            getHurt();
        }
    }

    void getHurt()
    {
        var color = gotHitScreen.GetComponent<Image>().color;
        color.a = 0.5f;

        gotHitScreen.GetComponent<Image>().color = color;
        audioS.Play();
    }

    public void OneMaxHP()
    {
        heartsOnScreen = 1;
        health = 1;
    }

    public void TwoMaxHP()
    {

        heartsOnScreen = 2;
        health = 2;
    }

    public void ThreeMaxHP()
    {
        heartsOnScreen = 3;
        health = 3;
    }

    public void FourMaxHP()
    {
        heartsOnScreen = 4;
        health = 4;
    }

    public void FiveMaxHP()
    {
        heartsOnScreen = 5;
        health = 5;
    }

    public void SfxTurnOn()
    {
        audioS.volume = 0.25f;
    }

    public void SfxTurnOff()
    {
        audioS.volume = 0;
    }
}
