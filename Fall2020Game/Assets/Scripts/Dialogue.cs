using System;
using System.Net.Mime;
using UnityEngine;
using Random = System.Random;

public class Dialogue : MonoBehaviour
{
 public string lineOne = "what's that?", lineTwo = "I wonder what that is?";
 public bool ageBeforeBeauty;
 
 public void OnMouseDown()
 {
  RandomText();
 }
 private void RandomText()
 {
  if (ageBeforeBeauty)
  {
   print(lineOne);
  }
  else
  {
   print(lineTwo);
  }
 }
}

