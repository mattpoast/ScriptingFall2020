using System;
using System.Collections.Generic;
using UnityEngine;

public class Collecting : MonoBehaviour
{
    public List<string> powerUps;

    public void Start()
    {
        foreach (var item in powerUps)
        {
            print(item);
        }
    }
}
