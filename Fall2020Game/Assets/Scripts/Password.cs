using System;
using UnityEngine;

public class Password : MonoBehaviour
{
    public string password;
    public GameObject player;
    void Start()
    {
        password = String.Empty;
    }

    private void Update()
    {
        if (password.Equals("please"))
        {
          print("working!!!");
          player.transform.Translate(0, 5 * Time.deltaTime,0);
        }
    }
}
