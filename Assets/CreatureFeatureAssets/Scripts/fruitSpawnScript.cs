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
        }
        currentFruit = null;
    }

    public void makeFruit()
    {
        fruitGO.transform.position = new Vector3(0, 0, 0);
        fruitGO.transform.rotation = Quaternion.identity;
    }
}
