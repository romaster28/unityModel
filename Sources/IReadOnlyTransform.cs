using System;
using UnityEngine;

public interface IReadOnlyTransform
{
    Vector3 Position { get; }
    Quaternion Rotation { get; }
    Vector3 Scale { get; }
    Vector3 Forward { get; }
    
    event Action<Vector3> PositionUpdated;
    event Action<Quaternion> RotationUpdated;
    event Action<Vector3> ScaleUpdated;
}