public class SpecialAttackState : IPlayerState
{
    public void HandleInput(Player player, PlayerDirectionAttack playerInput)
    {
        if (playerInput.AttackPlayer.SpecialAttack.IsPressed())
        {
            player.Animator.SetBool("SpecialAttack", true);
        }
        else
        {
            player.Animator.SetBool("SpecialAttack", false);
        }
    }

}
