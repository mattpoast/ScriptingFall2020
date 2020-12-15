using UnityEngine;

public class Obsticles : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0;
        print("Game Over");
    }
}
