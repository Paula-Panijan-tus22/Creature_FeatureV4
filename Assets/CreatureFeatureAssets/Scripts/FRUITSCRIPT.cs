using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FRUITSCRIPT : MonoBehaviour
{
    public bool isApple = false;
    public bool isPear = false;
    public bool isOrange = false;
    public Transform spawnPoint;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(Player.transform.position, transform.position) > 2 || transform.position.y < 0.05f)
        {
            Respawn();
        }
    }

    public void Respawn()
    {
        transform.position = spawnPoint.position;
        transform.rotation = spawnPoint.rotation;
    }
}
