using UnityEngine;

public class BootsScript : MonoBehaviour
{
    public GameObject boots;
    public int speed = 5;

    private void OnTriggerEnter(Collider other)
    {
        boots.SetActive(false);
        speed += 5;
    }
}
