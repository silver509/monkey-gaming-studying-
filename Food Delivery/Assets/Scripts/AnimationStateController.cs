using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AnimationStateController : MonoBehaviour
{
    [SerializeField] PlayerMovement script;
    public Animator animator;
    public Rigidbody rb;

    private void Start()
    {
     

    }

    void Update()
    {
       
        if(Mathf.Round(Math.Abs(rb.velocity.magnitude)) > 0)
        {
            animator.SetBool("isWalking", true);
        } else
        {
            animator.SetBool("isWalking", false);
        }
    }
}
