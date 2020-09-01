using UnityEngine;

public class MoverScript : MonoBehaviour
{
    public float x,y,z;
    public float speed = 5f;
    void Start()
    {
        Debug.Log("Hello World!");
    }
    void Update()
    {
        x = Input.GetAxis("Horizontal")*speed*Time.deltaTime;
        y = Input.GetAxis("Vertical")*speed*Time.deltaTime;
        transform.Translate(x,y,z);
    }
}
