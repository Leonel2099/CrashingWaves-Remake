using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerDirectionAttack _playerInput;
    [SerializeField] private Animator _animator;
    [SerializeField] private List<IPlayerState> states;

    public Animator Animator { get => _animator; set => _animator = value; }

    void Start()
    {
        _playerInput = new PlayerDirectionAttack();
        _playerInput.AttackPlayer.Enable();
        states = new List<IPlayerState>
        {
            new DirectionAttackState("DirectionAttackUp"),
            new DirectionAttackState("DirectionAttackDown"),
            new DirectionAttackState("DirectionAttackLeft"),
            new DirectionAttackState("DirectionAttackRight"),
            new SpecialAttackState()
        };

    }
    void Update()
    {
        DirectionAttack();
    }

    private void DirectionAttack()
    {
        foreach (var state in states)
        {
            state.HandleInput(this, _playerInput);
        }
    }
}
