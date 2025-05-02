using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hatSpawner : MonoBehaviour
{
    public Transform spawnPoint;  // Assign the spawn location in the Inspector
  private GameObject spawnedObject;  // Stores reference to the spawned object
  public Vector3 spawnOffset;

  // Function to spawn or destroy the object
  public void ToggleObject(GameObject objectPrefab)
    {
        if (spawnedObject == null)  // If no object exists, spawn it
        {
      spawnedObject = Instantiate(objectPrefab, spawnPoint.position + spawnOffset, spawnPoint.rotation);
      spawnedObject.transform.SetParent(spawnPoint);  // Parent it to the spawnPoint
        }
        else  // If object exists, destroy it
        {
            Destroy(spawnedObject);
            spawnedObject = null;  // Reset reference
        }
    }
}