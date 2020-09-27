using System;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject bullets;
    private void OnTriggerEnter(Collider other)
    {
Destroy(bullets);
    }
}
