using Leopotam.Ecs;
using UnityEngine;

public class FollowSystem : IEcsRunSystem
{
    private readonly EcsWorld _world = null;
    
    private readonly EcsFilter<FollowComponent, DirectionComponent, ModelComponent> _movableFilter = null;
    
    public void Run()
    {
        foreach (int i in _movableFilter)
        {
            ref var followComponent = ref _movableFilter.Get1(i);
            ref var directionComponent = ref _movableFilter.Get2(i);
            ref var modelComponent = ref _movableFilter.Get3(i);
            
            ref var direction = ref directionComponent.Direction;
            ref var target = ref followComponent.Target;
            ref var model = ref modelComponent.ModelTransform;
            
            direction = (target.position - model.position).normalized;
        }
    }
}