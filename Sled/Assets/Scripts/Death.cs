using UnityEngine;

public class Death : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Crash"))
        {
            Time.timeScale = 0;
        }
    }

}
