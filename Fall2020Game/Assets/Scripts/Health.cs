using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 10;
    public bool death;
    public float armor = 5f;
    public GameObject player;

    void Start()
    {
        death = false;
    }

    void Update()
    {
        death = true;
        if (death = true)
        {
            player.SetActive(false);
        }
    }
}
    

