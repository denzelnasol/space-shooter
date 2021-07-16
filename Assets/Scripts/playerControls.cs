using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControls : MonoBehaviour
{
    public float moveSpeed = 20f;
    float leftMove = 0f;
    float rightMove = 0f;

    public Animator playerAnimator;
    public Rigidbody2D rb;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        leftMove = Input.GetAxisRaw("Horizontal") * moveSpeed;
        playerAnimator.SetFloat("Speed", Mathf.Abs(leftMove));

        rightMove = Input.GetAxisRaw("Horizontal") * moveSpeed;
        playerAnimator.SetFloat("Speed", rightMove);

        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
