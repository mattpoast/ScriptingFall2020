using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;

    public void OnMouseDown()
    {
        player.SetActive(false);
    }
}
