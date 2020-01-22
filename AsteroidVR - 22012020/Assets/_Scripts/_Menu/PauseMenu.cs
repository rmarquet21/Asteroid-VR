using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.Extras;

public class PauseMenu : MonoBehaviour 
{
    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;
    public GameObject laserInput;
    public GameObject currentMenu;
    public GameObject Isolement;

    public SteamVR_Action_Boolean pauseAction;
    public SteamVR_Input_Sources handType;


    // Update is called once per frame
    void Update()
    {
        if (pauseAction.GetStateDown(handType))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        Isolement.SetActive(false);
        laserInput.SetActive(false);
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    {
        Isolement.SetActive(true);
        laserInput.SetActive(true);
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

    }

    public void Previous(GameObject panel)
    {
        currentMenu.SetActive(false);
        currentMenu = panel;
        currentMenu.SetActive(true);

    }

    public void Next(GameObject panel)
    {
        currentMenu.SetActive(false);
        currentMenu = panel;
        currentMenu.SetActive(true);
    }
}
