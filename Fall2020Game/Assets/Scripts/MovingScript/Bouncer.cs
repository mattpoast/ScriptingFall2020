using UnityEngine;
public class Bouncer : MonoBehaviour
{
    public GameObject player;
    public int bounce = 5;
    public void OnTriggerEnter(Collider other)
    {
        player.transform.Translate(0, bounce,0);
    }
}
