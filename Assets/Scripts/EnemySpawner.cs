using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] WavesConfigSO currentWave;
    
    void Start()
    {
        SpawnEnemies();
    }

    public WavesConfigSO GetCurrentWave()
    {
        return currentWave;
    }

    void SpawnEnemies()
    {
        for(int i = 0; i < currentWave.GetEnmeyCount(); i++)
        {
            Instantiate(currentWave.GetEnemyPrefab(i), 
                        currentWave.GetStartWayPoint().position,
                        Quaternion.identity,
                        transform);
        }
    }
}
