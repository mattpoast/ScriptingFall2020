using UnityEngine;
public class SledMover : MonoBehaviour
{
    public float moveSpeed = 20f;
        private Vector3 moveDirection;
        public CharacterController controller;
        public Vector3 sledPower;
        public float g = 9.81f;
        private bool isGrounded;
        public float jumpForce = 100f;
        private void Start()
        {
            controller.velocity.Equals(sledPower);
        }
        public void Update()
        {
            
            var moveSpeedInput = moveSpeed * Input.GetAxis("Horizontal");
    
            moveDirection.Set(moveSpeedInput, -g, 0);
             controller.Move(moveDirection * Time.deltaTime);
             controller.Move(sledPower * Time.deltaTime);

             if (Input.GetKeyDown(KeyCode.Space))
             {
                 moveDirection.Set(moveSpeedInput, jumpForce, 0);
             }
             
        }

        
}
