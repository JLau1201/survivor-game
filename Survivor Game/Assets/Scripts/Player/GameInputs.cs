using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInputs : MonoBehaviour
{

    public static GameInputs Instance { get; private set; }

    private PlayerInputActions inputActions;

    private void Awake() {
        Instance = this;
        inputActions = new PlayerInputActions();
        inputActions.Enable();
    }

    // Return noramlized movement vector
    public Vector2 GetMoveInputNormalized() {
        return inputActions.Player.Move.ReadValue<Vector2>().normalized;
    }
}
