using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    public int health = 3;
    private void OnTriggerEnter(Collider other)
    {
        health -= 1;
        if (health <=0)
        {
           player.SetActive(false); 
        }
    }
}
