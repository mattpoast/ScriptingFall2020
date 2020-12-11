using System;
using UnityEngine;

public class ChairMover : MonoBehaviour
{
    public Rigidbody rb;

    private void Start()
    {
        rb.velocity = new Vector3(0,-3,3);
    }
}
