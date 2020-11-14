using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Password : MonoBehaviour
{
    public string password;
    public AudioSource puzzleSolved;
    public AudioSource puzzleNotSolved;
    void Start()
    {
        password = String.Empty;
    }
    private void OnMouseDown()
    {
        if (password.Equals("Please"))
        {
            print("Access Granted");
            puzzleSolved.Play();
            StartCoroutine(DelayedTime());
        }
        else
        {
            print("Try Again");
            puzzleNotSolved.Play();
        }
    }
    IEnumerator DelayedTime()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
        print("working");
    }
}
