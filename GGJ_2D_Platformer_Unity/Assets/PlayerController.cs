using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Monobehaviour {

  //public float speed;
  //public float jumpForce;
  private float moveInput;

  // for flipping
  private bool facingRight = true;

  // variables to deal with player body
  private Rigidbody2D rb;
  public SpriteRenderer sr; //drag and drop the sprite rendere of your player from inscpector to the script.

  // variables to help with jumping
  //private bool isGrounded;
  //public Transform groundCheck;
  //public float checkRadius;
  //public LayerMask whatIsGround;

  //public int extraJumps;

  void start() {
    rb = GetComponent<Rigidbody2D>(); // get Rigidbody of player
  }

  void FixedUpdate() {
    // Check if player is on the ground
    isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);


    //moveInput = Input.GetAxis("Horizontal");
    if (Input.GetKeyDown(KeyCode.W))
         pos.y += spacing;
     if (Input.GetKeyDown(KeyCode.S))
         pos.y -= spacing;
     if (Input.GetKeyDown(KeyCode.A)) {
         pos.x -= spacing;
         sr.flipX = true;
       }
     if (Input.GetKeyDown(KeyCode.D)) {
         pos.x += spacing;
         sr.flipX = false;
       }


    // Update velocity based on key-press
    rb.velocity = new Vector2(moveInput*speed, rb.velocity.y);
  }

  void update() {

  }

}
