using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Collector : MonoBehaviour
{
    public GameObject brain;
    public int counter;

    private void OnTriggerEnter(Collider other)
    {
         if (CompareTag("collectable"))
         {
             counter += 1; 
             print(counter);
             brain.SetActive(false);
         }

         if (counter == 5)
         {
             Debug.Log("Winner");
         }
    }
}


