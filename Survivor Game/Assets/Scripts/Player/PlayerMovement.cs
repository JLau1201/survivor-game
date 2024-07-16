using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [Header("Speed")]
    [SerializeField] private float moveSpeed;

    private Rigidbody rb;

    private void Awake() {
        rb = GetComponent<Rigidbody>();
    }

    private void Update() {
        HandleMove();
    }

    // Move player
    private void HandleMove() {
        Vector2 moveInput = GameInputs.Instance.GetMoveInputNormalized();

        Vector3 moveDir = new Vector3(moveInput.x, 0f, moveInput.y);

        rb.MovePosition(rb.position + moveDir * moveSpeed * Time.deltaTime);
    }
}
