using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class eatFruitScript : MonoBehaviour
{
    public UnityEvent happy;
    public UnityEvent sad;
    public GameObject thoughtCloud;
    public GameObject appleSprite;
    public GameObject orangeSprite;
    public GameObject pearSprite;

    public AudioClip happySound;
    public AudioClip sadSound;
    private AudioSource audioSource;

    private float countdown_;
    private bool thinkingOfFruit;
    private int whichFruit;

    void Start()
    {
        thoughtCloud.SetActive(false);
        appleSprite.SetActive(false);
        orangeSprite.SetActive(false);
        pearSprite.SetActive(false);
        countdown_ = 20;
        thinkingOfFruit = false;

        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    void Update()
    {
        countdown_ -= Time.deltaTime;
        if (countdown_ < 0 && !thinkingOfFruit)
        {
            thinkOfFruit();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collided");
        if (thinkingOfFruit)
        {
            var fruit = collision.gameObject.GetComponent<FRUITSCRIPT>();
            if (fruit)
            {
                bool correctFruit = false;

                if (whichFruit == 1 && fruit.isApple) correctFruit = true;
                else if (whichFruit == 2 && fruit.isOrange) correctFruit = true;
                else if (whichFruit == 3 && fruit.isPear) correctFruit = true;

                if (correctFruit)
                {
                    happy.Invoke();
                    PlaySound(happySound);
                }
                else
                {
                    sad.Invoke();
                    PlaySound(sadSound);
                }

                countdown_ = Random.Range(15, 25);
                thoughtCloud.SetActive(false);
                appleSprite.SetActive(false);
                orangeSprite.SetActive(false);
                pearSprite.SetActive(false);
                thinkingOfFruit = false;

                fruit.Respawn();
            }
            else
            {
                Debug.Log("not fruit");
            }
        }
    }

    private void thinkOfFruit()
    {
        thinkingOfFruit = true;
        whichFruit = Random.Range(1, 4); // Fix range to include 3
        thoughtCloud.SetActive(true);
        appleSprite.SetActive(whichFruit == 1);
        orangeSprite.SetActive(whichFruit == 2);
        pearSprite.SetActive(whichFruit == 3);
    }

    private void PlaySound(AudioClip clip)
    {
        if (clip != null && audioSource != null)
        {
            audioSource.PlayOneShot(clip);
        }
    }
}