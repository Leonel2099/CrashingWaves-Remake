using UnityEngine;

public class PatrolMovementEnemy : IMoveEnemy
{
    private float speed;
    private string direction;
    private Transform _transform;
    private Animator animator;
    private Transform[] breakpoints;
    private int PatrolIndex = 0;

    public PatrolMovementEnemy(float speed, Transform transform, Animator animator, Transform[] breakpoints, string direction)
    {
        this.speed = speed;
        this._transform = transform;
        this.animator = animator;
        this.breakpoints = breakpoints;
        this.direction = direction;
    }

    public void Move()
    {
        SetMoveAnimation(direction);
        MoveToPatrolPoint();
    }

    private void SetMoveAnimation(string sentido)
    {
        animator.SetBool(sentido, true);
    }

    private void MoveToPatrolPoint()
    {
        _transform.position = Vector2.MoveTowards(_transform.position, breakpoints[PatrolIndex].position, speed * Time.deltaTime);

        // Si el enemigo alcanza el breackpoint actual, ataca
        if (Vector2.Distance(_transform.position, breakpoints[PatrolIndex].position) < 0.1f)
        {
            speed = 0;
            animator.SetFloat("speed", speed);
        }
    }
}
