using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    [SerializeField]
    private Transform[] spawnPoints;
    [SerializeField]
    private GameObject blockPrefab;

    private void Start()
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