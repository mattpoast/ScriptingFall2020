using UnityEngine;
using UnityEngine.Experimental.UIElements;
public class AttackScript : MonoBehaviour
{
    public GameObject enemy;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            enemy.SetActive(false);
        }
    }
}
