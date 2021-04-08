using UnityEngine;

[CreateAssetMenu(fileName = "Attack Settings", menuName = "Attack/Settings")]
public class AttackSettings : ScriptableObject
{
    [Range(0, 10f)] [SerializeField] private float _rate;

    public float Rate => _rate;
}
