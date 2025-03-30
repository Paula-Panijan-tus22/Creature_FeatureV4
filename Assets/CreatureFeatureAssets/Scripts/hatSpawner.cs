using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hatSpawner : MonoBehaviour
{
    public GameObject objectPrefab;  // Assign the prefab in the Inspector
    public Transform spawnPoint;  // Assign the spawn location in the Inspector

    private GameObject spawnedObject;  // Stores reference to the spawned object

    public void ToggleObject()
    {
        if (spawnedObject == null)  // If no object exists, spawn it
        {
            spawnedObject = Instantiate(objectPrefab, spawnPoint.position, spawnPoint.rotation);
        }
        else  // If object exists, destroy it
        {
            Destroy(spawnedObject);
            spawnedObject = null;  // Reset reference
        }
    }
}
