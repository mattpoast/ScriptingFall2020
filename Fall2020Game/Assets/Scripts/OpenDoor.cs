using System;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngineInternal;

public class OpenDoor : MonoBehaviour
{
  public GameObject wall;
  public GameObject door;
  public bool truth;

  private void Start()
  {
      truth = false;
      door.SetActive(true);
  }
  public void OnMouseDown()
  {
      if (truth = true)
      {
          door.SetActive(false);
      }
  }
}


