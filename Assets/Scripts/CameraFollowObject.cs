using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowObject : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Transform _target;

    [Header("Settings")]
    [SerializeField] private bool _preserveOffset;

    private Vector3 _offset;

    private void Awake()
    {
        if (_preserveOffset)
        {
            _offset = transform.position - _target.position;
        }
        else
        {
            _offset = new Vector3();
        }
    }

    private void FixedUpdate()
    {
        UpdatePosition();
    }

    private void UpdatePosition()
    {
        transform.position = _target.position + _offset;
    }
}
