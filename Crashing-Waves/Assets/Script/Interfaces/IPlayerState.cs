public interface IPlayerState
{
    void HandleInput(Player player, PlayerDirectionAttack playerInput);
    void SufferDamage(Player player);
}
