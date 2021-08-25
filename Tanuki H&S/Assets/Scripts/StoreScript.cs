using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StoreScript : MonoBehaviour
{
    public GameObject OrbPurchasePanel;
    public GameObject TearPurchasePanel;
    public GameObject InsFunds;
    public int OCost = 0;
    public Text OCostUI;
    public int TCost = 0;
    public Text TCostUI;
    public int OrbPrice = 0;
    public int TearPrice = 0;
    public void OCostCounter(int Value)
    {
        OCost = Value;
        OCostUI.text = "" + OCost;
    }
    public void TCostCounter(int Value)
    {
        TCost = Value;
        TCostUI.text = "" + TCost;
    }
    public void OrbsYesPurchase()
    {
        if (CurrencyDisplayScript.instance.Orbs >= OCost)
        {
            CurrencyDisplayScript.instance.Orbs -= OCost;
            CurrencyDisplayScript.instance.OrbsUI.text = "" + CurrencyDisplayScript.instance.Orbs;
            OrbPurchasePanel.SetActive(false);
        }
        else
        {
            InsFunds.SetActive(true);
            OrbPurchasePanel.SetActive(false);
        }
    }
    public void TearsYesPurchase()
    {
        if (CurrencyDisplayScript.instance.Tears >= TCost)
        {
            CurrencyDisplayScript.instance.Tears -= TCost;
            CurrencyDisplayScript.instance.TearsUI.text = "" + CurrencyDisplayScript.instance.Tears;
            TearPurchasePanel.SetActive(false);
        }
        else
        {
            InsFunds.SetActive(true);
            TearPurchasePanel.SetActive(false);
        }
    }
    public void OrbCancel()
    {
        OrbPurchasePanel.SetActive(false);
    }
    public void TearCancel()
    {
        TearPurchasePanel.SetActive(false);
    }
    public void OkayButton()
    {
        InsFunds.SetActive(false);
    }
    public void OrbPurchase()
    {
        OrbPrice = 50;
        OCostCounter(OrbPrice);
        OrbPurchasePanel.SetActive(true);
    }
    public void RareOrbPurchase()
    {
        OrbPrice = 75;
        OCostCounter(OrbPrice);
        OrbPurchasePanel.SetActive(true);
    }
    public void EpicOrbPurchase()
    {
        OrbPrice = 100;
        OCostCounter(OrbPrice);
        OrbPurchasePanel.SetActive(true);
    }
    public void TearPurchase()
    {
        TearPrice = 50;
        TCostCounter(TearPrice);
        TearPurchasePanel.SetActive(true);
    }
    public void RareTearPurchase()
    {
        TearPrice = 75;
        TCostCounter(TearPrice);
        TearPurchasePanel.SetActive(true);
    }
    public void EpicTearPurchase()
    {
        TearPrice = 100;
        TCostCounter(TearPrice);
        TearPurchasePanel.SetActive(true);
    }
}
