using Leopotam.Ecs;
using UnityEngine;

public class MovementSystem : IEcsRunSystem
{
    private readonly EcsWorld _world = null;
    
    private readonly EcsFilter<ModelComponent, MovableComponent, DirectionComponent> _movableFilter = null;


    public void Run()
    {
        foreach (int i in _movableFilter)
        {
            ref var modelComponent = ref _movableFilter.Get1(i);
            ref var movableComponent = ref _movableFilter.Get2(i);
            ref var directionComponent = ref _movableFilter.Get3(i);
            
            ref var direction = ref directionComponent.Direction;
            ref var transform = ref modelComponent.ModelTransform;
            ref var speed = ref movableComponent.MoveSpeed;
            
            var rawDirection = (transform.right * direction.x) + (transform.up * direction.y);
            transform.Translate(rawDirection * speed * Time.deltaTime);
        }
    }
    
}
