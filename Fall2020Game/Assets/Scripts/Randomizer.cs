using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Randomizer : MonoBehaviour
{
    public GameObject cube, circle;
    private string names;

    private void Start()
    {
        Randomizer.Instantiate(cube);
        Debug.Log("working");

    }
}
