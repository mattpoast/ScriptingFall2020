using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Net : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void PerformSwing() => animator.SetTrigger("Swing");

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            PerformSwing();
    }
    
    
    }
