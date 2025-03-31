using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingHandPoses : MonoBehaviour
{

    public GameObject spherePrefab; // Assign a sphere prefab in the inspector

    void Start()
    {
       // SpawnRedSphere();
    }

    public void SpawnRedSphere()
    {
        if (spherePrefab != null)
        {
            GameObject sphere = Instantiate(spherePrefab, transform.position, Quaternion.identity);
            Renderer sphereRenderer = sphere.GetComponent<Renderer>();
            if (sphereRenderer != null && sphereRenderer.material != null)
            {
                sphereRenderer.material.SetColor("_BaseColor", Color.red);
            }
        }
        else
        {
            Debug.LogWarning("Sphere prefab is not assigned!");
        }
    }
}
