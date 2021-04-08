using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private InputObject _target;

    private void Update()
    {
        UpdateInput();
    }

    private void UpdateInput()
    {
        _target.Horizontal = Input.GetAxis("Horizontal");
        _target.Vertical = Input.GetAxis("Vertical");
        _target.Attack = Input.GetMouseButton(0);
    }
}
