using System;
using UnityEngine;

public class SledMover : MonoBehaviour
{
    private float moveSpeed = 10f;
    private Vector3 moveDirection;
    public CharacterController controller;
    public Vector3 power;
    private void Start()
    {
        controller.velocity.Equals(power);
    }
    public void Update()
    {
        var moveSpeedInput = moveSpeed * Input.GetAxis("Horizontal");

        moveDirection.Set(moveSpeedInput, 0, 0);
         controller.Move(moveDirection * Time.deltaTime);
         controller.Move(power * Time.deltaTime);
    }
    
}