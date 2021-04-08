using UnityEngine;

[CreateAssetMenu(fileName = "Player Input", menuName = "Input/Player")]
public class InputObject : ScriptableObject
{
    [HideInInspector] public float Horizontal;
    [HideInInspector] public float Vertical;
    [HideInInspector] public bool Attack;
}

