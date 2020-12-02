using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        player.SetActive(false);
        Time.timeScale = 0;
       
    }
}
