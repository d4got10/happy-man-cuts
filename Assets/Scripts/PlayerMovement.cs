using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private InputObject _input;

    [Header("Settings")]
    [SerializeField] private MovementSettings _settings;

    private void Awake()
    {
    }

    private void FixedUpdate()
    {
        var moveDirection = Vector3.ClampMagnitude(new Vector3(_input.Horizontal, 0, _input.Vertical), 1);

        var prevY = _rigidbody.velocity.y;

        _rigidbody.velocity = moveDirection * _settings.Speed + new Vector3(0, prevY, 0);
    }
}
