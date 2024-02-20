using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawner spawner;
    // Start is called before the first frame update
    void Start()
    {
        spawner = GameObject.FindObjectOfType<GroundSpawner>();
        SpawnObstacle();
    }

    private void OnTriggerExit(Collider other)
    {
        spawner.SpawnTile();
        Destroy(gameObject, 2);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    // Obstacles
    public GameObject obstaclePrefab;

    void SpawnObstacle()
    {
        // Choose a random point to spawn the obstacle
        int obstacleSpawIndex = Random.Range(2, 5);
        Transform spawnPoint = transform.GetChild(obstacleSpawIndex).transform;

        // Spawn the obstacle at that position
        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
    }
}
