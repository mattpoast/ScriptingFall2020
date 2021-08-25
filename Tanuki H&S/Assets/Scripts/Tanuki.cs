using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tanuki : MonoBehaviour
{
    public GameObject tanuki = null;
    public GameObject hunter = null;
    public GameObject worm = null;
    public GameObject watermelon = null;
    public GameObject sign = null;
    public GameObject frog = null;

    // Start is called before the first frame update
    void Start()
    {
        tanuki.SetActive(true);
        hunter.SetActive(false);
        worm.SetActive(false);
        watermelon.SetActive(false);
        sign.SetActive(false);
        frog.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            Change();
        if (Input.GetKeyDown(KeyCode.Q))
            Revert();
        if (Input.GetKeyDown(KeyCode.Alpha1))
            Worm();
        if (Input.GetKeyDown(KeyCode.Alpha2))
            WaterMelon();
        if (Input.GetKeyDown(KeyCode.Alpha3))
            Sign();
        if (Input.GetKeyDown(KeyCode.Alpha4))
            Frog();
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Net")
            Capture();
    }
    void Revert()
    {
        tanuki.SetActive(true);
        hunter.SetActive(false);
        worm.SetActive(false);
        watermelon.SetActive(false);
        sign.SetActive(false);
        frog.SetActive(false); ;
    }
    void Change()
    {
        tanuki.SetActive(false);
        hunter.SetActive(true);
        worm.SetActive(false);
        watermelon.SetActive(false);
        sign.SetActive(false);
        frog.SetActive(false);
    }
    void Worm()
    {
        tanuki.SetActive(false);
        hunter.SetActive(false);
        worm.SetActive(true);
        watermelon.SetActive(false);
        sign.SetActive(false);
        frog.SetActive(false);
    }

    void WaterMelon()
    {
        tanuki.SetActive(false);
        hunter.SetActive(false);
        worm.SetActive(false);
        watermelon.SetActive(true);
        sign.SetActive(false);
        frog.SetActive(false);
    }
    void Sign()
    {
        tanuki.SetActive(false);
        hunter.SetActive(false);
        worm.SetActive(false);
        watermelon.SetActive(false);
        sign.SetActive(true);
        frog.SetActive(false);
    }
    void Frog()
    {
        tanuki.SetActive(false);
        hunter.SetActive(false);
        worm.SetActive(false);
        watermelon.SetActive(false);
        sign.SetActive(false);
        frog.SetActive(true);
    }
 
    void Capture()
    {
      gameObject.SetActive(false);
    }
}
