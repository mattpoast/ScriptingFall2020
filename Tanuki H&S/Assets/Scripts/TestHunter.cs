using UnityEngine;
public class TestHunter : MonoBehaviour
{
	
	public float moveSpeed = 7f;
	void Update()
    {
	
	float moveHorizontal = Input.GetAxisRaw ("Horizontal");
	float moveVertical = Input.GetAxisRaw ("Vertical");

	Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
	movement.Normalize();
	if (movement != Vector3.zero)
	{
		transform.rotation = Quaternion.Slerp(transform.rotation,Quaternion.LookRotation(movement.normalized),0.2f);
	}
	transform.Translate (moveSpeed * Time.deltaTime * movement, Space.World);
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "TestTanuki")
        {
			;
        }
    }
}
