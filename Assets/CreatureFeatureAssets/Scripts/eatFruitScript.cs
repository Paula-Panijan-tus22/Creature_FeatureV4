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
    private float countdown_;
    private bool thinkingOfFruit;
    private int whichFruit;

    // Start is called before the first frame update
    void Start()
    {
        thoughtCloud.SetActive(false);
        appleSprite.SetActive(false);
        orangeSprite.SetActive(false);
        pearSprite.SetActive(false);
        countdown_ = 20;
        thinkingOfFruit = false;
    }

    void Update()
    {
        countdown_ -= Time.deltaTime;
        if (countdown_ > 0 && !thinkingOfFruit)
        {
            thinkOfFruit();
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (thinkingOfFruit)
        {
            if (collision.gameObject.GetComponent<FRUITSCRIPT>())
            {
                if (whichFruit == 1)
                {
                    if (collision.gameObject.GetComponent<FRUITSCRIPT>().isApple)
                    {
                        happy.Invoke();
                    } else
                    {
                        sad.Invoke();
                    }
                }
                else if (whichFruit == 2)
                {
                    if (collision.gameObject.GetComponent<FRUITSCRIPT>().isOrange)
                    {
                        happy.Invoke();
                    }
                    else
                    {
                        sad.Invoke();
                    }
                }
                else if (whichFruit == 3)
                {
                    if (collision.gameObject.GetComponent<FRUITSCRIPT>().isPear)
                    {
                        happy.Invoke();
                    }
                    else
                    {
                        sad.Invoke();
                    }
                }
                countdown_ = Random.Range(15,25);
                thoughtCloud.SetActive(false);
                appleSprite.SetActive(false);
                orangeSprite.SetActive(false);
                pearSprite.SetActive(false);
                thinkingOfFruit = false;
                collision.gameObject.GetComponent<FRUITSCRIPT>().Respawn();
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
        whichFruit = Random.Range(1, 3);
        thoughtCloud.SetActive(true);
        if (whichFruit == 1)
        {
            appleSprite.SetActive(true);
        } else if (whichFruit == 2)
        {
            orangeSprite.SetActive(true);
        } else if(whichFruit == 3)
        {
            pearSprite.SetActive(true);
        }
    }
}
