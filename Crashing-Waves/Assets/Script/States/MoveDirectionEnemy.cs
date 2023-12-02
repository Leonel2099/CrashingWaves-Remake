using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDirection : IMoveDirection
{
    public Vector2 GetMoveVector(string direction)
    {
        switch (direction)
        {
            case "Left":
                return new Vector2(-1, 0).normalized;
            case "Up":
                return new Vector2(0, 1).normalized;
            case "Right":
                return new Vector2(1, 0).normalized;
            case "Down":
                return new Vector2(0, -1).normalized;
            default:
                return Vector2.zero;
        }
    }
}
