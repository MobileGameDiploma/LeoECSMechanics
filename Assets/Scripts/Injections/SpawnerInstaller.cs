using UnityEngine;
using Zenject;

public class SpawnerInstaller : MonoInstaller
{
    public FollowProvider prefab;
    public float Delay;
    public Transform[] SpawnPoints;
    public Transform Target;

    public override void InstallBindings()
    {
        Container.Bind<FollowProvider>().FromInstance(prefab).AsSingle().NonLazy();
        Container.Bind<float>().FromInstance(Delay).AsSingle().NonLazy();
        Container.Bind<Transform[]>().FromInstance(SpawnPoints).AsSingle().NonLazy();
        Container.Bind<Transform>().FromInstance(Target).AsSingle().NonLazy();
    }
}
