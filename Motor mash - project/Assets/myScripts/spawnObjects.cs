using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnObjects : MonoBehaviour
{
   public GameObject[] objectPrefabs;
    private float spawnDelay = 2;
    public GameObject User;

    // Start is called before the first frame update
    void Start()
    {
        User = GameObject.Find("player");
        InvokeRepeating("SpawnObjects", spawnDelay, Random.Range(1.5f,7));
    }

    // Spawn obstacles
    void SpawnObjects ()
    {
        // Set random spawn location and random object index
        Vector3 spawnLocation = new Vector3(Random.Range(1,10), 1, User.transform.position.z + Random.Range(10,20));
        int index = Random.Range(0, objectPrefabs.Length);
        Instantiate(objectPrefabs[index], spawnLocation, objectPrefabs[index].transform.rotation);
        
    }
}
