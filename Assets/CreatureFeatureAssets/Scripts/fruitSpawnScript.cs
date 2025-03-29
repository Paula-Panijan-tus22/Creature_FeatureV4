using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitSpawnScript : MonoBehaviour
{
    public GameObject fruitGO;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject currentFruit = GameObject.Find("Fruit");
        if (currentFruit = null)
        {
            Debug.Log("no fruit in scene");
            Instantiate(fruitGO);
        }
        currentFruit = null;
    }

    public void makeFruit()
    {
        Instantiate(fruitGO, transform.position , transform.rotation);
    }
}
