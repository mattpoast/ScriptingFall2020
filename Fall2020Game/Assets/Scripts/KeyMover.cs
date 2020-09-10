
using System;
using UnityEngine;

public class KeyMover : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody rb;
    public Vector2 bounceRight;
    public Vector2 bounceLeft;
    public GameObject wall1, wall2;
    private void Start()
    {
        bounceRight = new Vector2(-15,0);
        bounceLeft = new Vector2(15, 0);
    }

    private void OnCollisionEnter(Collision other)
    {
        if(wall1)
        {
            rb.AddForce(speed * bounceLeft, ForceMode.Impulse);
        }

        if (wall2)
        {
            rb.AddForce(speed * bounceRight, ForceMode.Impulse);
        }
        
    }
}
