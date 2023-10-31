using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerState
{
    void HandleInput(Player player, PlayerDirectionAttack playerInput);
}
