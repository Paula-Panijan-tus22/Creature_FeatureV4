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

    [Header("Action Cooldown")]
    [Tooltip("Time in seconds before another action can be triggered")]
    public float actionCooldown = 2f;

    private float lastActionTime = -Mathf.Infinity;

    void Awake()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    public void Dance()
    {
        if (CanPerformAction())
        {
            ResetAllTriggers();
            animator.SetTrigger("Dance");
            PlaySound(danceClip);
            UpdateLastActionTime();
        }
    }

    public void Wave()
    {
        if (CanPerformAction())
        {
            ResetAllTriggers();
            animator.SetTrigger("Wave");
            PlaySound(waveClip);
            UpdateLastActionTime();
        }
    }

    public void SitDown()
    {
        if (CanPerformAction())
        {
            ResetAllTriggers();
            animator.SetTrigger("Sit");
            UpdateLastActionTime();
        }
    }

    public void Spin()
    {
        if (CanPerformAction())
        {
            ResetAllTriggers();
            animator.SetTrigger("Spin");
            PlaySound(spinClip);
            UpdateLastActionTime();
        }
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

    private bool CanPerformAction()
    {
        return Time.time >= lastActionTime + actionCooldown;
    }

    private void UpdateLastActionTime()
    {
        lastActionTime = Time.time;
    }
}