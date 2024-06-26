using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] List<WavesConfigSO> wavesConfigs;
    [SerializeField] float timeBetweenWaves = 0f;
    [SerializeField] bool isLooping;
    WavesConfigSO currentWave;

    
    void Start()
    {
        StartCoroutine(SpawnEnemyWaves());
    }

    public WavesConfigSO GetCurrentWave()
    {
        return currentWave;
    }

    IEnumerator SpawnEnemyWaves()
    {
        do
        {
            foreach(WavesConfigSO wave in wavesConfigs)
                {
                    currentWave = wave;
                    for(int i = 0; i < currentWave.GetEnmeyCount(); i++)
                    {
                        Instantiate(currentWave.GetEnemyPrefab(i), 
                                    currentWave.GetStartWayPoint().position,
                                    Quaternion.Euler(0, 0, 180),
                                    transform);
                        yield return new WaitForSeconds(currentWave.GetRandomSpawnTime());
                    }
                    yield return new WaitForSeconds(timeBetweenWaves);
                }
        }
        while(isLooping);
        


    }
}
