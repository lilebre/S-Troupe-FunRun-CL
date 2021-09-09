using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseOverlay;
    public GameObject settingsButton;
    public GameObject settingsMenu;
    public GameObject settingsMenuTwo;
    public GameObject playerModel;
    public GameObject screenshotButton;


    public void PauseGame()
    {
        Time.timeScale = 0;
        pauseOverlay.SetActive(true);
        settingsButton.SetActive(false);
        screenshotButton.SetActive(false);

    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        pauseOverlay.SetActive(false);
        settingsButton.SetActive(true);
        screenshotButton.SetActive(true);
    }

    public void QuitApplication()
    {
        Debug.Log("App Quit");
        Application.Quit();
    }

    public void OpenSettings()
    {
        pauseOverlay.SetActive(false);
        settingsMenu.SetActive(true);

    }

    public void ReturnToMenu()
    {
        pauseOverlay.SetActive(true);
        settingsMenu.SetActive(false);
        settingsMenuTwo.SetActive(false);
    }

    public void SettingsPageTwo()
    {
        settingsMenu.SetActive(false);
        settingsMenuTwo.SetActive(true);    
    }

    public void SettingsPageOne()
    {
        settingsMenu.SetActive(true);
        settingsMenuTwo.SetActive(false);
    }

    public void ChangeColorDefault()
    {
        var playerModelRenderer = playerModel.GetComponent<Renderer>();
        playerModelRenderer.material.SetColor("_Color", Color.white);
    }

    public void ChangeColorRed()
    {
        var playerModelRenderer = playerModel.GetComponent<Renderer>();
        playerModelRenderer.material.SetColor("_Color", Color.red);
    }

    public void ChangeColorOrange()
    {
        var playerModelRenderer = playerModel.GetComponent<Renderer>();
        playerModelRenderer.material.color = new Color32(255, 165, 0, 0);
    }

    public void ChangeColorYellow()
    {
        var playerModelRenderer = playerModel.GetComponent<Renderer>();
        playerModelRenderer.material.SetColor("_Color", Color.yellow);
    }

    public void ChangeColorGreenish()
    {
        var playerModelRenderer = playerModel.GetComponent<Renderer>();
        playerModelRenderer.material.color = new Color32(193, 243, 89, 0);
    }

    public void ChangeColorTurqouise()
    {
        var playerModelRenderer = playerModel.GetComponent<Renderer>();
        playerModelRenderer.material.color = new Color32(48, 213, 200, 0);
    }

    public void ChangeColorGreen()
    {
        var playerModelRenderer = playerModel.GetComponent<Renderer>();
        playerModelRenderer.material.SetColor("_Color", Color.green);
    }

    public void ChangeColorCyan()
    {
        var playerModelRenderer = playerModel.GetComponent<Renderer>();
        playerModelRenderer.material.SetColor("_Color", Color.cyan);
    }

    public void ChangeColorLightBlue()
    {
        var playerModelRenderer = playerModel.GetComponent<Renderer>();
        playerModelRenderer.material.color = new Color32(137, 207, 240, 0);
    }

    public void ChangeColorDarkBlue()
    {
        var playerModelRenderer = playerModel.GetComponent<Renderer>();
        playerModelRenderer.material.SetColor("_Color", Color.blue);
    }

    public void ChangeColorPurple()
    {
        var playerModelRenderer = playerModel.GetComponent<Renderer>();
        playerModelRenderer.material.color = new Color32(114, 76, 255, 0);
    }

    public void ChangeColorPink()
    {
        var playerModelRenderer = playerModel.GetComponent<Renderer>();
        playerModelRenderer.material.color = new Color32(255, 0, 224, 0);
    }
}
