using UnityEngine;

public class NewMover : MonoBehaviour
{
    public CharacterController controller;
    public float jumpPower = 15f;
    private float yDirection;
    public float gravity = -30f;
    public float moveSpeed = 10f;
    void Update()
    {
         var moveSpeedInput = Input.GetAxisRaw("Horizontal");
                 var moveSpeedInputZ = Input.GetAxisRaw("Vertical");
                 Vector3 direction = new Vector3(moveSpeedInput, yDirection, moveSpeedInputZ).normalized; 
        yDirection += gravity * Time.deltaTime;

        controller.Move(direction * moveSpeed * Time.deltaTime);
        if (controller.isGrounded && direction.y <0)
        {
            yDirection = -1f; 
        }
                
        if (Input.GetButtonDown("Jump"))
        {
            yDirection = jumpPower;
        }
    }
}
