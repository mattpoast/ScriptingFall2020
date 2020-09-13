using UnityEngine;
public class DeathScreen : MonoBehaviour
{
    public GameObject player;
    public GameObject deathScreen;
    void Start()
    {
        deathScreen.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        player.SetActive(false);
        deathScreen.SetActive(true);
        
    }
}
