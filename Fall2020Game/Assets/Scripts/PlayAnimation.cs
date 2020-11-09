using UnityEngine;
using UnityEngine.Video;

public class PlayAnimation : MonoBehaviour
{
  public VideoPlayer coffinDrop;

  public void OnMouseDown()
  {
    coffinDrop.targetCameraAlpha = 0.5f;
  }
}
