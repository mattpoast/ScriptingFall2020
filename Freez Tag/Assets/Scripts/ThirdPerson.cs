using UnityEngine;
public class ThirdPerson : MonoBehaviour
{
    public float moveSpeed = 10f;
    public CharacterController controller;
    public float gravity = -9.81f;
    private float yDirection;
    private float turnSmoothVelocity;
    public float turnSmoothTime = 0.1f;
    public Transform cam;
    void Update()
    {
        var moveSpeedInput = Input.GetAxisRaw("Horizontal");
         var moveSpeedInputZ = Input.GetAxisRaw("Vertical");
         Vector3 direction = new Vector3(moveSpeedInput,0f, moveSpeedInputZ).normalized;
        
         yDirection += gravity * Time.deltaTime;
         
        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity,
                turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * moveSpeed * Time.deltaTime);
        }
        
        if (controller.isGrounded && direction.y <0)
        {
            yDirection = -1f;
        }
    }
}
