using System;
using UnityEngine;
public class ItemMenu : MonoBehaviour
{
  public GameObject itemMenu;
  public Vector3 up;
  public Vector3 down;
  public float speed = 5f;
  private void Start()
  {
    itemMenu.SetActive(true);
  }
  private void OnMouseEnter()
  {
    itemMenu.SetActive(true);
    transform.Translate(Time.deltaTime * speed * up);
    itemMenu.transform.Translate(Time.deltaTime * speed * up);
  }
  private void OnMouseExit()
  {
    transform.Translate(Time.deltaTime * speed * down);
    itemMenu.transform.Translate(Time.deltaTime * speed * down);
  }
}
