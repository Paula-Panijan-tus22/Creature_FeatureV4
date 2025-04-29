using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator animator;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void Dance()
    {
        ResetAllTriggers();
        animator.SetTrigger("Dance");
    }

    public void Wave()
    {
        ResetAllTriggers();
        animator.SetTrigger("Wave");
    }

    public void SitDown()
    {
        ResetAllTriggers();
        animator.SetTrigger("Sit");
    }

    public void Spin()
    {
        ResetAllTriggers();
        animator.SetTrigger("Spin");
    }

    private void ResetAllTriggers()
    {
        animator.ResetTrigger("Dance");
        animator.ResetTrigger("Wave");
        animator.ResetTrigger("Sit");
        animator.ResetTrigger("Spin");
    }
}