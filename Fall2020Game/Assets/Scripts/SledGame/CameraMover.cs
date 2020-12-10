using UnityEngine;

public class CameraMover : MonoBehaviour
{
    void Start()
    {
       GetComponent<Rigidbody>().velocity = new Vector3(0,-3,3);
    }

}
