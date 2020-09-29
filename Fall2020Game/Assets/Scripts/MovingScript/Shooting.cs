using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public int bulletForce = 5;


    private void OnMouseDown()
    {
        Instantiate(bullet);
    }
}
