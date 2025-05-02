using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator animator;
    private AudioSource audioSource;

    [Header("Animation Audio Clips")]
    public AudioClip danceClip;
    public AudioClip waveClip;
    public AudioClip spinClip;

    void Awake()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    public void Dance()
    {
        ResetAllTriggers();
        animator.SetTrigger("Dance");
        PlaySound(danceClip);
    }

    public void Wave()
    {
        ResetAllTriggers();
        animator.SetTrigger("Wave");
        PlaySound(waveClip);
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
        PlaySound(spinClip);
    }

    private void PlaySound(AudioClip clip)
    {
        if (clip != null)
        {
            audioSource.Stop(); // Stop any currently playing sound
            audioSource.clip = clip;
            audioSource.loop = false;
            audioSource.Play();
        }
    }

    private void ResetAllTriggers()
    {
        animator.ResetTrigger("Dance");
        animator.ResetTrigger("Wave");
        animator.ResetTrigger("Sit");
        animator.ResetTrigger("Spin");
    }
}
