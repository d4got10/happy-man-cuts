using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Animator _animator;
    [SerializeField] private InputObject _input;

    [Header("Settings")]
    [SerializeField] private AttackSettings _settings;

    private const string ATTACK_KEYWORD = "Attack";

    private float _lastAttackTime;

    private void Awake()
    {
        _lastAttackTime = float.MinValue;
    }

    private void Update()
    {
        if (_input.Attack && CanAttack())
        {
            Attack();
        }        
    }

    private bool CanAttack()
    {
        return (Time.time > _lastAttackTime + _settings.Rate);
    }

    private void Attack()
    {
        _animator.SetTrigger(ATTACK_KEYWORD);
        OnAttack();
    }

    private void OnAttack()
    {
        _lastAttackTime = Time.time;
    }
}
