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
    }

    public void Wave()
    {
        animator.SetBool("isWaving", true);
    }

    public void SitDown()
    {
        animator.SetBool("isSitting", true);
    }

    public void Spin()
    {
        animator.SetBool("isSpinning", true);
    }
}
