
using System;
using UnityEngine;

public class KeyMover : MonoBehaviour
{
    public float speed = 5f;
    public Vector3 mover;

    public void Update()
    {
        mover.x = speed * Time.deltaTime;
      transform.Translate(mover);
      if (mover.x < 2)
      {
          print("working");
          transform.Translate(mover);
          mover.y = speed;
      }
   
    }
}
