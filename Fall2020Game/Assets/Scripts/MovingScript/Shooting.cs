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
    private Vector3 bulletDirection;
    private void OnMouseDown()
    {
        Instantiate(bullet);
              transform.Translate(bulletDirection);
      bulletDirection.x  = bulletForce * Time.deltaTime;
  bullet.SetActive(true);
    }

    private void Update()
    {
        timer += 1f * Time.deltaTime;
        if (timer >= 5f)
        {
            bullet.SetActive(false);
        }

        if (timer >= 6f)
        {
            timer = 0f;
        }
    }
}
