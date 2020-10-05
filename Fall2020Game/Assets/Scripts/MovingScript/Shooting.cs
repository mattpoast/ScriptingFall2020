using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public int bulletForce = 5;
    private float timer;
    private void OnMouseDown()
    {
        Instantiate(bullet);
        bullet.transform.Translate(bulletForce, 0, 0);
    }

    private void Update()
    {
        timer += 1f * Time.deltaTime;
        if (timer >= 5f)
        {
            Destroy(bullet);
        }
    }
}
