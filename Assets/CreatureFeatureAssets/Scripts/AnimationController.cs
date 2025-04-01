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
        animator.SetBool("isDancing", true);
        animator.SetBool("isWaving", false);
        animator.SetBool("isSitting", false);
        animator.SetBool("isSpinning", false);
    }

    public void Wave()
    {
        animator.SetBool("isWaving", true);
        animator.SetBool("isDancing", false);
        animator.SetBool("isSitting", false);
        animator.SetBool("isSpinning", false);
    }

    public void SitDown()
    {
        animator.SetBool("isSitting", true);
        animator.SetBool("isDancing", false);
        animator.SetBool("isWaving", false);
        animator.SetBool("isSpinning", false);
    }

    public void Spin()
    {
        animator.SetBool("isDancing", false);
        animator.SetBool("isSpinning", true);
        animator.SetBool("isWaving", false);
        animator.SetBool("isSitting", false);
    }
}
