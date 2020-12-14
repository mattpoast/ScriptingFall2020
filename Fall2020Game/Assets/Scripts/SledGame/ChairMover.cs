using System;
using UnityEngine;

public class ChairMover : MonoBehaviour
{
    public Rigidbody rb;
    private float moveSpeed = 10f;
    private Vector3 moveDirection;
    public CharacterController controller;
    public Vector3 gasBaby;
    private void Start()
    {
        rb.velocity = new Vector3(0, -9, 9);
    }
    public void Update()
    {
        var moveSpeedInput = moveSpeed * Input.GetAxis("Horizontal");

        moveDirection.Set(moveSpeedInput, 0, 0);
         controller.Move(moveDirection * Time.deltaTime);
         controller.Move(gasBaby * Time.deltaTime);
    }
    
}
