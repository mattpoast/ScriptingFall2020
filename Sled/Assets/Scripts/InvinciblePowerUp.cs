using UnityEngine;
public class InvinciblePowerUp : MonoBehaviour
{
    public GameObject star;
    public bool starTrue;

    public void Start()
    {
        starTrue = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        star.SetActive(false);
        print("StarActive");
        starTrue = true;
        if (other.gameObject.CompareTag("Obstacle") && starTrue)
        {
            Destroy(other.gameObject);
        }
    }
}
