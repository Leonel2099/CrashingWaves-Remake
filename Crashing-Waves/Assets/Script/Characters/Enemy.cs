using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed;
    private Animator _playerMoveAnim;
    private IMoveEnemy _movementStrategy;
    [SerializeField] private string direction;
    [SerializeField] private Transform[] breackpoints;

    private void Start()
    {
        _playerMoveAnim = GetComponent<Animator>();
        _movementStrategy = new PatrolMovementEnemy(speed, transform, _playerMoveAnim, breackpoints, direction);
    }

    private void Update()
    {
        _movementStrategy.Move();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        _playerMoveAnim.SetBool("Death", true);

    }
}
