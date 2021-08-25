using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenCanvas : MonoBehaviour
{
    public string StartGameScene;
    public enum MenuStates { Main, Customize, Settings, Store };
    public MenuStates CurrentState;
    public MenuStates NewState;
    public GameObject MainMenu;
    public GameObject CustomizeMenu;
    public GameObject SettingsMenu;
    public GameObject StoreMenu;
    // Start is called before the first frame update
    void Awake()
    {
        CurrentState = MenuStates.Main;
    }
    public void StartGame()
    {
        SceneManager.LoadScene(StartGameScene);
    }

    public void Customize()
    {
        SwitchMenu(MenuStates.Customize);
    }

    public void Settings()
    {
        SwitchMenu(MenuStates.Settings);
    }

    public void Store()
    {
        SwitchMenu(MenuStates.Store);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Return()
    {
        SwitchMenu(MenuStates.Main);
    }

    private void SwitchMenu(MenuStates menu)
    {
        switch (menu)
        {
            case MenuStates.Main:
                MainMenu.SetActive(true);
                CustomizeMenu.SetActive(false);
                SettingsMenu.SetActive(false);
                StoreMenu.SetActive(false);
                break;
            case MenuStates.Customize:
                CustomizeMenu.SetActive(true);
                MainMenu.SetActive(false);
                break;
            case MenuStates.Settings:
                SettingsMenu.SetActive(true);
                MainMenu.SetActive(false);
                break;
            case MenuStates.Store:
                StoreMenu.SetActive(true);
                MainMenu.SetActive(false);
                break;
        }
    }
}
