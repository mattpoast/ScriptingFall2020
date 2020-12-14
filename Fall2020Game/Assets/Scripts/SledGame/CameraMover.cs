using System;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    public CharacterController cam;
    public Vector3 cameraGas;

    public void Update()
    {
        cam.Move(cameraGas * Time.deltaTime);
    }
}
