using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public GameObject CameraBound = null;
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "TestHunter")
        {
            CameraBound.transform.position = new Vector3(2.95f, 31.5f, -92.5f);
        }
    }
}