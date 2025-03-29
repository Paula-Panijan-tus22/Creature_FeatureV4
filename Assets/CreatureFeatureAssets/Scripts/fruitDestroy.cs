using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class fruitDestroy : MonoBehaviour
{
    public UnityEvent spawnFruit;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("[BuildingBlock] Camera Rig");
    }

    // Update is called once per frame
    void Update()
    {
        if (Player == null)
        {
            Player = GameObject.Find("[BuildingBlock] Camera Rig");
        }
        Debug.Log(Vector3.Distance(Player.transform.position, transform.position));
        if (Vector3.Distance(Player.transform.position, transform.position) > 2)
        {
            spawnFruit.Invoke();
            Destroy(this.gameObject);
        }
    }
}
