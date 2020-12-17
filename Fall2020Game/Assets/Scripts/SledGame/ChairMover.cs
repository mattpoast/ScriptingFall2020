using System;
using UnityEngine;

public class ChairMover : MonoBehaviour
{
    private float moveSpeed = 10f;
    private Vector3 moveDirection;
    public CharacterController controller;
    public Vector3 gasBaby;
    private void Start()
    {
        controller.velocity.Equals(gasBaby);
    }
    public void Update()
    {
        var moveSpeedInput = moveSpeed * Input.GetAxis("Horizontal");

        moveDirection.Set(moveSpeedInput, 0, 0);
         controller.Move(moveDirection * Time.deltaTime);
         controller.Move(gasBaby * Time.deltaTime);
    }
    
}
