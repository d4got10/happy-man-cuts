using UnityEngine;

[CreateAssetMenu(fileName = "Movement Settings", menuName = "Movement/Settings")]
public class MovementSettings : ScriptableObject
{
    [Range(0.1f, 5)] [SerializeField] private float _speed;

    public float Speed => _speed;
}
