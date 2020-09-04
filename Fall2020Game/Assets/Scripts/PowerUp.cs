using UnityEngine;
public class PowerUp : MonoBehaviour
{
    public int powerUpValue = 3;
    public GameObject powerUp;
    public int score;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(powerUp);
        score += powerUpValue;
    }
}
    

