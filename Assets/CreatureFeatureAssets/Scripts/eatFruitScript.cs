using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class eatFruitScript : MonoBehaviour
{
    public UnityEvent happy;
    public UnityEvent sad;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == 3)
        {
            happy.Invoke();
            Destroy(collision.gameObject);
        }
    }

    
}
