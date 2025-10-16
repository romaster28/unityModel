using System;
using UnityEngine;

public class TransformModel
{
    private Vector3 _position;
    private Quaternion _rotation;
    private Vector3 _scale;

    public Vector3 Position
    {
        get => _position;
        private set
        {
            _position = value;
            PositionUpdated?.Invoke(value);
        }
    }

    public Quaternion Rotation
    {
        get => _rotation;
        private set
        {
            _rotation = value;
            RotationUpdated?.Invoke(value);
        }
    }

    public Vector3 Scale
    {
        get => _scale;
        private set
        {
            _scale = value;
            ScaleUpdated?.Invoke(value);
        }
    }

    public event Action<Vector3> PositionUpdated;
    public event Action<Quaternion> RotationUpdated;
    public event Action<Vector3> ScaleUpdated; 
    
    public TransformModel(Vector3 position)
    {
        Position = position;
    }

    public TransformModel(Vector3 position, Quaternion rotation)
    {
        Position = position;
        Rotation = rotation;
    }

    public TransformModel(Vector3 position, Quaternion rotation, Vector3 scale)
    {
        Position = position;
        Rotation = rotation;
        Scale = scale;
    }
}