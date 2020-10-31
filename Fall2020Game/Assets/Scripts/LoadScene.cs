using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
   private void OnMouseDown()
   {
      SceneManager.LoadScene(1);
      print ("working");
   }
}
