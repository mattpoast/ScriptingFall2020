using UnityEngine;

public class Restart : MonoBehaviour
{
    public Vector3 home;
    public GameObject player;

    private void Start()
    {
        home.x = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("working");
      player.transform.Translate(home);
    }
}
