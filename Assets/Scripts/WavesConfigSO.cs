using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

[CreateAssetMenu(menuName = "Wave Config", fileName = "New wave Config")] 
public class WavesConfigSO : ScriptableObject
{
    [SerializeField] List<GameObject> enemyPrefabs;
    [SerializeField] Transform pathPrefab;
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float timeBetweenEnemey = 1f;
    [SerializeField] float spawnTimeVariance = 0f;
    [SerializeField] float minimumSpawnTime = 0.2f; 

    public Transform GetStartWayPoint()
    {
        return pathPrefab.GetChild(0);
    }

    public List<Transform> GetWayPoint()
    {
        List<Transform> waypoints = new List<Transform>();
        foreach(Transform child in pathPrefab)
        {
            waypoints.Add(child);
        }
        return waypoints;
    }

    public float GetMoveSpeed()
    {
        return moveSpeed;
    }

    public int GetEnmeyCount()
    {
        return enemyPrefabs.Count;
    }

    public GameObject GetEnemyPrefab(int index)
    {
        return enemyPrefabs[index];
    }

    public float GetRandomSpawnTime()
    {
        float SpawnTime = Random.Range(timeBetweenEnemey - spawnTimeVariance,
                                        timeBetweenEnemey + spawnTimeVariance);
        return Mathf.Clamp(SpawnTime, minimumSpawnTime, float.MaxValue);
    }
}
