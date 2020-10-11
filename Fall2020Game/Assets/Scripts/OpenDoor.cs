using System;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class OpenDoor : MonoBehaviour
{
  public GameObject wall;

  public void OnTriggerEnter(Collider other)
  {
       wall.transform.Translate(0, -5, 0);
  }
}

