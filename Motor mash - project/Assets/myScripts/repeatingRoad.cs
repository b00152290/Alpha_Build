using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralRoadGenerator : MonoBehaviour
{
    public GameObject[] roadPrefabs;  
    public GameObject player;
    private Vector3 startPos;
    private float repeatRoad;

    private void Start()
    {
        player = GameObject.Find("player");
        startPos = transform.position; 
        repeatRoad = GetComponent<BoxCollider>().size.z;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (player)
        {
            SpawnNewRoad();
        }
    }
    void SpawnNewRoad()
    {
        
        Instantiate(GetRandomRoadPrefab(), startPos + Vector3.forward * repeatRoad, Quaternion.identity);

        
        startPos += Vector3.forward * repeatRoad;
    }

    GameObject GetRandomRoadPrefab()
    {
        
        int randomIndex = Random.Range(0, roadPrefabs.Length);
        return roadPrefabs[randomIndex];
    }
}
