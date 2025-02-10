using System;
using Leopotam.Ecs;
using UnityEngine;
using Voody.UniLeo;

public class EcsGameStartup : MonoBehaviour
{
    private EcsWorld _world;
    private EcsSystems _systems;

    private void Start()
    {
        _world = new EcsWorld();
        _systems = new EcsSystems(_world);

        _systems.ConvertScene();
        
        AddInjections();
        AddOneFrames();
        AddSystems();
        
        _systems.Init();
    }

    private void Update()
    {
        _systems.Run();
    }

    private void AddInjections()
    {
        
    }

    private void AddSystems()
    {
        
    }

    private void AddOneFrames()
    {
        
    }

    private void OnDestroy()
    {
        if(_systems == null)
            return;
        
        _systems.Destroy();
        _systems = null;
        _world.Destroy();
        _world = null;
    }
}
