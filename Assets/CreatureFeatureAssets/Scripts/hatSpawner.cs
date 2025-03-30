using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hatSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;  // Assign the prefab to spawn in the Inspector
    public Transform spawnPoint;  // Assign the spawn location in the Inspector

    public void SpawnObject()
    {
        if (objectToSpawn != null && spawnPoint != null)
        {
            Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);
        }
        else
        {
            Debug.LogError("Object or Spawn Point not assigned in ObjectSpawner!");
        }
    }

}
