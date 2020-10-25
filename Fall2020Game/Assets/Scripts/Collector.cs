using UnityEngine;
public class Collector : MonoBehaviour
{
    public GameObject brain;
    public int counter;
    public AudioSource brainSquish;

    private void OnTriggerEnter(Collider other)
    {
         
        counter += 1; 
        print(counter);
        brain.SetActive(false);
       
        if (counter == 5)
        {
             Debug.Log("Winner");
        }
    }

    private void OnMouseDown()
    {
        brainSquish.Play();
    }
}


