using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D _rbPlayer;
    private Animator _playerMoveAnim;
    private IMoveDirection _moveDirection;
    [SerializeField] private string direction;

    private void Start()
    {
        _playerMoveAnim = GetComponent<Animator>();
        _rbPlayer = GetComponent<Rigidbody2D>();
        _moveDirection = new MoveDirection();
    }

    private void Update()
    {
        SetMoveAnimation(direction);
        SetMovement(direction);
    }

    private void SetMoveAnimation(string direction)
    {
        _playerMoveAnim.SetBool(direction, true);
    }

    private void SetMovement(string direction)
    {
        Vector2 move = _moveDirection.GetMoveVector(direction);
        _rbPlayer.MovePosition(_rbPlayer.position + speed * Time.fixedDeltaTime * move);
    }
}
