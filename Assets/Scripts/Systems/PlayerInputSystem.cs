using Leopotam.Ecs;
using UnityEngine;

public class PlayerInputSystem : IEcsRunSystem
{
    private readonly EcsFilter<PlayerTag, DirectionComponent> _directionFilter = null;

    private float moveX;
    private float moveY;
    
    public void Run()
    {
        SetDirection();
        
        foreach (int i in _directionFilter)
        {
            ref var directionComponent = ref _directionFilter.Get2(i);
            ref var direction = ref directionComponent.Direction;
            
            direction.x = moveX;
            direction.y = moveY;
        }
    }

    private void SetDirection()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
    }
}