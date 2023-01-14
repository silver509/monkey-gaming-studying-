using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    [SerializeField] PlayerMovement driving;
    public Animator animator;
    public Rigidbody rb;

    private void Start()
    {
     

    }

    void Update()
    {
       
        if(driving.driving == true)
        {
            animator.SetBool("isWalking", true);
        } else
        {
            animator.SetBool("isWalking", false);
        }
    }
}
