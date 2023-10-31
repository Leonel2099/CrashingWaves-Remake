using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionAttackState : IPlayerState
{
    private string direction;

    public DirectionAttackState(string direction)
    {
        this.direction = direction;
    }

    public void HandleInput(Player player, PlayerDirectionAttack playerInput)
    {
        if (playerInput.FindAction(direction).IsPressed())
        {
            player.Animator.SetBool(direction, true);
        }
        else
        {
            player.Animator.SetBool(direction, false);
        }
    }

    public void SufferDamage(Player player)
    {
        throw new System.NotImplementedException();
    }
}
