using System;
using UnityEngine;
using UnityEngine.Video;

public class PlayAnimation : MonoBehaviour
{
  public VideoPlayer coffinDrop;

  private void OnMouseEnter()
  {
    coffinDrop.Play();
  }
}
