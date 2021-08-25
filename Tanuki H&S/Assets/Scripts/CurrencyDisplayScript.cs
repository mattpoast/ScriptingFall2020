using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CurrencyDisplayScript : MonoBehaviour
{
    public static CurrencyDisplayScript instance;
    
    public int Tears = 0;
    public int Orbs = 0;
    public Text TearsUI;
    public Text OrbsUI;
    public int TearRewards = 9;
    public int OrbRewards = 6;
    void Awake()
    {
        instance = this;
    }
    public void TearCounter(int amount)
    {
        Tears += amount;
        TearsUI.text = "" + Tears;
    }
    public void OrbCounter(int amount)
    {
        Orbs += amount;
        OrbsUI.text = "" + Orbs;
    }

    public void Jackpot()
    {
        TearCounter(TearRewards);
        OrbCounter(OrbRewards);
    }
}
