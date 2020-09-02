using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject sphere;

    public void OnTriggerEnter(Collider other)
    {
        sphere.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
