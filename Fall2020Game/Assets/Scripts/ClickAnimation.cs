using System;
using UnityEngine;
public class ClickAnimation : MonoBehaviour
{
 public Animation idleAnimationOne;
 public Animation idleAnimationTwo;

 private void OnMouseDown()
 {
  idleAnimationOne.Play();
 }
}
