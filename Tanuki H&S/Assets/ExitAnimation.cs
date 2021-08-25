using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitAnimation : MonoBehaviour
{
    
    
    [SerializeField] private Animator Fade;
    [SerializeField] private Animator TestHunter;


    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "TestHunter")
            RoomTrans();
    }
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.name == "TestHunter")
            Fade.SetBool("FadeUpTrans", false);
            TestHunter.SetBool("ExitTrans", false);
    }
    public void RoomTrans()
    {
        Fade.SetBool("FadeUpTrans", true);
        TestHunter.SetBool("ExitTrans", true);


    }

            


 
}
