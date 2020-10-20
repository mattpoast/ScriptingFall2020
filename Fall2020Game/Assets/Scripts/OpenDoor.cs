using UnityEngine;

public class OpenDoor : MonoBehaviour
{
  public GameObject wall;
  public GameObject door;
  public bool lockedDoor;

  private void Start()
  {
      lockedDoor = false;
      door.SetActive(true);
  }
  public void OnMouseDown()
  {
      if (lockedDoor = true)
      {
          door.SetActive(false);
      }
  }
}


