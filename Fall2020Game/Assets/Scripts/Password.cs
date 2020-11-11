using System;
using UnityEngine;

public class Password : MonoBehaviour
{
    public string password;
    public GameObject player;
    public AudioSource puzzleSolved;
    public AudioSource puzzleNotSolved;
    void Start()
    {
        password = String.Empty;
    }
    private void Update()
    {
        if (password.Equals("please"))
        {
          print("Access Granted");
          puzzleSolved.Play();
        }
        else
        {
            print("Try Again");
            puzzleNotSolved.Play();
        }
    }
}
