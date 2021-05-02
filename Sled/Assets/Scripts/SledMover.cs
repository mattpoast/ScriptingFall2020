using UnityEngine;
public class SledMover : MonoBehaviour
{
        public float moveSpeed = 400f;
        private Vector3 moveDirection;
        public CharacterController controller;
        public Vector3 sledPower;
        public float gravity = -9.81f;
        private float yDirection;
        public float jumpForce = 100f;
        private void Start()
        {
            controller.velocity.Equals(sledPower);
        }
        public void Update()
        {
            var moveSpeedInput = moveSpeed * Input.GetAxis("Horizontal");
    
            moveDirection.Set(moveSpeedInput, yDirection, 0);
            yDirection += gravity * Time.deltaTime;
            
             controller.Move(moveDirection * Time.deltaTime);
             controller.Move(sledPower * Time.deltaTime);

             if (controller.isGrounded && moveDirection.y < 0)
             {
                 yDirection = -1f;
             }

             if (Input.GetButtonDown("Jump"))
             {
                 yDirection = jumpForce;
             }
        }

        
}
