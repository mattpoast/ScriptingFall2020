using UnityEngine;
public class SledMover : MonoBehaviour
{
    public float moveSpeed = 20f;
        private Vector3 moveDirection;
        public CharacterController controller;
        public Vector3 sledPower;
        private void Start()
        {
            controller.velocity.Equals(sledPower);
        }
        public void Update()
        {
            var moveSpeedInput = moveSpeed * Input.GetAxis("Horizontal");
    
            moveDirection.Set(moveSpeedInput, 0, 0);
             controller.Move(moveDirection * Time.deltaTime);
             controller.Move(sledPower * Time.deltaTime);
        }

        
}
