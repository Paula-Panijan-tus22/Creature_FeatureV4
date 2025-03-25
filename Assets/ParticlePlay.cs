using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlePlay : MonoBehaviour
{
    private ParticleSystem _system;


    // Start is called before the first frame update
    void Start()
    {
        _system = GetComponent<ParticleSystem>();
    }

    public void PlayParticleSystem()
    {
        if (_system != null)
        {
            _system.Play();
        }
    }
}
