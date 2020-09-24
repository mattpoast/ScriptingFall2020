using UnityEngine;
public class MoverScript : MonoBehaviour
{
    private Vector3 moveDirection;
    private float yDirection;
    public float moveSpeed = 3f;
    public float gravity = -9.81f;
    public CharacterController controller;
    public float jumpForce = 10f;
    private void Update()
    {
        var moveSpeedInput = moveSpeed * Input.GetAxis("Horizontal");
        moveDirection.Set(moveSpeedInput,yDirection,0);
        yDirection += gravity * Time.deltaTime;

        if (controller.isGrounded && moveDirection.y < 0)
        {
            yDirection = -1f;
        }

        if (Input.GetButtonDown("Jump"))
        {
            yDirection = jumpForce;
        }

        controller.Move(moveDirection * Time.deltaTime);
    }

}
