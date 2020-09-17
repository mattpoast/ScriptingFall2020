
using System;
using UnityEngine;

public class KeyMover : MonoBehaviour
{
    public float speed = 5f;
    public Vector3 mover;
    public void Update()
    {
        transform.Translate(mover);
        if (mover.x < 2)
        {
            mover.x = speed * Time.deltaTime;
        }
        else
        {
            mover.x = -speed * Time.deltaTime;
        }
    }
}
