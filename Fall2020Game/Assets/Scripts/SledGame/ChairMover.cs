using System;
using UnityEngine;

public class ChairMover : MonoBehaviour
{
    public Rigidbody rb;
    public float chairGas;
    private int speed = 10;
    private Vector3 movment;
    public GameObject player;
    private void Start()
    {
        rb.velocity = new Vector3(0, -9, 9);
    }
    public void Move()
        {
        
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"),0,0);
        
        player.transform.position += movement * speed * Time.deltaTime;
        
        }
}
