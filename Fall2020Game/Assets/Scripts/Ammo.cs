using UnityEngine;

public class Ammo : MonoBehaviour
{
    public GameObject ammo;
    public int ammoCount;

    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
        ammoCount += 5;
    }
}
