using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    [SerializeField]
    private Transform[] spawnPoints;
    [SerializeField]
    private GameObject blockPrefab;
    [SerializeField]
    private float timeBetweenWaves = 1f;

    private float timeToSpawn = 2f;

    private void Update()
    {
        if(Time.time >= timeToSpawn)
        {
            SpawnBlocks();
            timeToSpawn = Time.time + timeBetweenWaves;
        }
    }

    private void SpawnBlocks()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex != i)
                Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
            else
                continue;
        }
    }

}