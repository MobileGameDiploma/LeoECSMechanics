using System;
using System.Collections;
using UnityEngine;

public class OjbectSpawner : MonoBehaviour
{
    public FollowProvider prefab;
    public float Delay;
    public Transform[] SpawnPoints;
    public Transform Target;
    
    private System.Random _random = new System.Random();

    private void Start()
    {
        prefab.SetTarget(Target);
        StartCoroutine(SpawnWithDelayLoop());
    }

    IEnumerator SpawnWithDelayLoop()
    {
        while (true)
        {
            yield return new WaitForSeconds(Delay);
            Instantiate(prefab.gameObject, SpawnPoints[_random.Next(SpawnPoints.Length)].position, Quaternion.identity);
        }
    }
}
