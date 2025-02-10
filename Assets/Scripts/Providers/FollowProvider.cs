using Unity.VisualScripting;
using UnityEngine;
using Voody.UniLeo;

public class FollowProvider : MonoProvider<FollowComponent>
{
    public void SetTarget(Transform target)
    {
        base.value.Target = target;
    }
}