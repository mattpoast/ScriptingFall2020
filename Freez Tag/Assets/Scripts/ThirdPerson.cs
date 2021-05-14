using UnityEngine;
public class ThirdPerson : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float lookSpeed = 5f;
    public Vector3 moveDirection;
    public CharacterController controller;
    public float gravity = -9.81f;
    private float yDirection;
    public float jumpPower = 15f;
    void Update()
    {
        var moveSpeedInput = moveSpeed * Input.GetAxis("Horizontal");
        var moveSpeedInputZ = moveSpeed * Input.GetAxis("Vertical");
        moveDirection.Set(moveSpeedInput, yDirection, moveSpeedInputZ);
        yDirection += gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

        if (controller.isGrounded && moveDirection.y <0)
        {
            yDirection = -1f;
        }
        if (Input.GetButtonDown("Jump"))
        {
            yDirection = jumpPower;
        }
    }
}
