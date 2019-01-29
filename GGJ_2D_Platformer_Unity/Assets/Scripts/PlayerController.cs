using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Thomas Maher

Updated 1/29/2019
*/

public class PlayerController : MonoBehaviour {

  public float moveSpeed;
  public Vector2 lastMove;
  private bool isMoving;

  // User's progress throughout the game
  public int progress;

  // static in Unity is a powerful & beautiful thing
  private static bool playerExists;

  public string startPoint;

  private Rigidbody2D rb;
  private Animator anim;

  void Start () {
    anim = GetComponent<Animator>();
    rb = GetComponent<Rigidbody2D>();

    if(!playerExists) {
      playerExists = true;
      // So that player exists when switching between scenes/levels
      DontDestroyOnLoad(transform.gameObject);
    }
    else { // To destroy duplicates
      Destroy(gameObject);
    }
  }

  void Update() {
    isMoving = false;

    // Basic movement of player
    if(Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f) {
      //rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal")*moveSpeed, rb.velocity.y);
      isMoving = true;
      lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
      transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal")*moveSpeed*Time.deltaTime, 0f, 0f));
    }

    if(Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f) {
      //rb.velocity = new Vector2(rb.velocity.x, Input.GetAxisRaw("Vertical")*moveSpeed);
      isMoving = true;
      lastMove = new Vector2(0f, Input.GetAxisRaw("Vertical"));
      transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical")*moveSpeed*Time.deltaTime, 0f));
    }

    // So player doesn't keep sliding
    if(Input.GetAxisRaw("Horizontal") < 0.5f && Input.GetAxisRaw("Horizontal") > -0.5f) {
      rb.velocity = new Vector2(0f, rb.velocity.y);
    }

    if(Input.GetAxisRaw("Vertical") < 0.5f && Input.GetAxisRaw("Vertical") > -0.5f) {
      rb.velocity = new Vector2(rb.velocity.x, 0f);
    }


    anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
    anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
    anim.SetBool("isMoving", isMoving);
    anim.SetFloat("LastMoveX", lastMove.x);
    anim.SetFloat("LastMoveY", lastMove.y);

  }
}
