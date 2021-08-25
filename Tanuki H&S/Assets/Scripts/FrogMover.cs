using UnityEngine;
public class FrogMover : MonoBehaviour
{
    public int animationPicker;
    public Animator frogAnimator;
    public float counter;
    public float moveSpeed = 1.5f;
    public float rotationSpeed = 150f;
    void Start()
    {
        frogAnimator = GetComponent<Animator>();
        StartCycle();
    }
    public void StartCycle()
    {
        animationPicker = Random.Range(0, 6);
        CountDown();
    }
    void Update()
    {
        if (animationPicker <= 3)
        {
            frogAnimator.SetBool("frogHop", true);
            counter -= Time.deltaTime;
            if (counter <= 0f)
            {
                frogAnimator.SetBool("frogHop", false);
                StartCycle();
            }
            switch (animationPicker)
            {
                case 0: Vector3 upMovement = new Vector3(0,0, moveSpeed * Time.deltaTime);
                    Quaternion upRotation = Quaternion.LookRotation(upMovement,Vector3.up);
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, upRotation, rotationSpeed * Time.deltaTime);
                    transform.Translate(upMovement, Space.World);
                    break;
                case 1:
                    Vector3 rightMovement = new Vector3(moveSpeed * Time.deltaTime,0,0);
                    Quaternion rightRotation = Quaternion.LookRotation(rightMovement,Vector3.up);
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, rightRotation, rotationSpeed * Time.deltaTime);
                    transform.Translate(rightMovement, Space.World);
                    break;
                case 2:
                    Vector3 downMovement = new Vector3(0,0,-moveSpeed * Time.deltaTime);
                    Quaternion downRotation = Quaternion.LookRotation(downMovement,Vector3.up);
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, downRotation, rotationSpeed * Time.deltaTime);
                    transform.Translate(downMovement, Space.World);
                    break;
                case 3:
                    Vector3 leftMovement = new Vector3(-moveSpeed * Time.deltaTime,0,0);
                    Quaternion leftRotation = Quaternion.LookRotation(leftMovement,Vector3.up);
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, leftRotation, rotationSpeed * Time.deltaTime);
                    transform.Translate(leftMovement, Space.World);
                    break;
            }
        }
        if (animationPicker == 4)
        {
            counter -= Time.deltaTime;
            frogAnimator.SetBool("frogCroak",true);
            if (counter <= 0f)
            {
               frogAnimator.SetBool("frogCroak", false); 
               StartCycle();
            }
        }
        if (animationPicker == 5)
        {
            counter -= Time.deltaTime;
         frogAnimator.SetBool("frogIdle",true);
         if (counter <= 0f)
         {
             frogAnimator.SetBool("frogIdle", false);
             StartCycle();
         }
        }
    }
    public void CountDown()
    {
        counter = Random.Range(1, 4);
    }
}