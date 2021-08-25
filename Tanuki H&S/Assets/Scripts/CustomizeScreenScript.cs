using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizeScreenScript : MonoBehaviour
{
    public enum CustomizeStates { Tanuki, Hunter }
    public CustomizeStates CurrentState;
    public CustomizeStates NewState;
    public GameObject TanukiMenu;
    public GameObject HunterMenu;
    void Awake()
    {
        CurrentState = CustomizeStates.Tanuki;
    }

    public void TanukiButton()
    {
        SwitchCustomize(CustomizeStates.Tanuki);
    }

    public void HunterButton()
    {
        SwitchCustomize(CustomizeStates.Hunter);
    }

    private void SwitchCustomize(CustomizeStates menu)
    {
        switch(menu)
        {
            case CustomizeStates.Tanuki:
                TanukiMenu.SetActive(true);
                HunterMenu.SetActive(false);
                break;
            case CustomizeStates.Hunter:
                HunterMenu.SetActive(true);
                TanukiMenu.SetActive(false);
                break;
        }
    }
}
