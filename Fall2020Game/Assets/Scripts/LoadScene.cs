using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
   {
      SceneManager.LoadScene(0);
   }
}
