using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject door;
  public bool lockedDoor;
  public AudioSource doorOpening;

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
          doorOpening.Play();
      }
  }
}


