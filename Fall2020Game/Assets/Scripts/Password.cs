using System;
using System.Timers;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Password : MonoBehaviour
{
    public string password;
    public AudioSource puzzleSolved;
    public AudioSource puzzleNotSolved;
    public float timeBoy;
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
            
            DelayedLoading();
        }
        else
        {
            print("Try Again");
            puzzleNotSolved.Play();
        }
        
    }
    public void DelayedLoading()
    {
        timeBoy += 1f * Time.deltaTime;
        if (timeBoy >= 3f)
        {
            SceneManager.LoadScene(1);
        }
    }
}
