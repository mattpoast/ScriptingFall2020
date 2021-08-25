using UnityEngine;
public class WormMove : MonoBehaviour
{
    public Animator wormWalk;
    public float moveSpeed = 2.5f;
    private float moveCounter;
    private float waitCounter;
    public bool isMoving;
    private int moveDirection;
    public float randomMove;
    public float rotationSpeed = 150;
    public float randomWait;
    void Start()
    {
        wormWalk = GetComponent<Animator>();
        moveCounter = 2f;
        waitCounter = randomWait;
        ChooseDirection();
        MoveTimeRandom();
        WaitTimeRandom();
    }
    void Update()
    {
        if (isMoving)
        {
            MoveTimeRandom();
            moveCounter -= Time.deltaTime;
            wormWalk.SetBool("isWalking", true);
            switch (moveDirection)
            {
                case  0 :
                    Vector3 upMovement = new Vector3(0,0, moveSpeed * Time.deltaTime);
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
            if (moveCounter <= 0)
            {
                WaitTimeRandom();
                isMoving = false;
                wormWalk.SetBool("isWalking", false);
                waitCounter = randomWait;
            }
        }
        else
        {
            waitCounter -= Time.deltaTime;
            if (waitCounter <= 0)
            {
                ChooseDirection();
            }
        }
    }
    public void ChooseDirection()
    {
        moveDirection = Random.Range(0, 4);
        isMoving = true;
        moveCounter = randomMove;
    }
    public void MoveTimeRandom()
    {
        randomMove = Random.Range(1, 6);
    }
    public void WaitTimeRandom()
    {
        randomWait = Random.Range(2, 6);
    }
}
