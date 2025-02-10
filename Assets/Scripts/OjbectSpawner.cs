using System;
using System.Collections;
using UnityEngine;
using Zenject;

public class OjbectSpawner : MonoBehaviour
{
    private FollowProvider _prefab;
    private float _delay;
    private Transform[] _spawnPoints;
    private Transform _target;

    [Inject]
    public void Construct(FollowProvider prefab, float delay, Transform[] spawnPoints, Transform target)
    {
        _prefab = prefab;
        _delay = delay;
        _spawnPoints = spawnPoints;
        _target = target;
    }
    
    private System.Random _random = new System.Random();

    private void Start()
    {
        _prefab.SetTarget(_target);
        StartCoroutine(SpawnWithDelayLoop());
    }

    IEnumerator SpawnWithDelayLoop()
    {
        while (true)
        {
            yield return new WaitForSeconds(_delay);
            Instantiate(_prefab.gameObject, _spawnPoints[_random.Next(_spawnPoints.Length)].position, Quaternion.identity);
        }
    }
}
