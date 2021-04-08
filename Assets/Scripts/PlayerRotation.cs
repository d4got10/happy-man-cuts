using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;

    private void FixedUpdate()
    {
        RotateTowardsVelocity();
    }

    private void RotateTowardsVelocity()
    {
        var direction = _rigidbody.velocity;
        direction.y = 0;
        if (direction.magnitude > 0.01f)
        {
            var angle = Vector3.SignedAngle(direction, transform.forward, Vector3.up);
            var rotation = transform.rotation.eulerAngles;

            rotation.y -= angle;
            transform.rotation = Quaternion.Euler(rotation);
        }
    }
}
