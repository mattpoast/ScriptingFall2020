using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject key;
    public GameObject door;
    void Start()
    {
        door.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(key);
        door.SetActive(false);
    }
}
