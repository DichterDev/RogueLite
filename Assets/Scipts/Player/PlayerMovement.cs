using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Player player;
    private Rigidbody2D rb;
    private float moveSpeed = 10f;
    public Animator animator;
    float VerticalMove;
    float HorizontalMove;

    Vector2 movement;

    private void Awake()
    {
        player = FindObjectOfType<Player>();
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        movement = movement.normalized;

        HorizontalMove = Input.GetAxisRaw("Horizontal") * moveSpeed;
        VerticalMove = Input.GetAxisRaw("Vertical") * moveSpeed;


        animator.SetFloat("Walk", VerticalMove);
        animator.SetFloat("Sideways", HorizontalMove);



        moveSpeed = player.Velocity;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

    }
}
