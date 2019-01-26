using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Thomas Maher
1/25/2019
*/

public class PlayerController : MonoBehaviour {

  public float moveSpeed;
  public Vector2 lastMove;

  // static in Unity is a powerful & beautiful thing
  private static bool playerExists;

  private Rigidbody2D rb;
  //private Animator anim;

  //private Vector3 pos; // For movement
  //private float speed = 2.0f; // Speed of movement

  void Start () {
    //anim = GetComponent<Animator>();
    rb = GetComponent<Rigidbody2D>();
    //pos = transform.position; // Take the initial position

    if(!playerExists) {
      playerExists = true;
      // So that player exists when switching between scenes/levels
      DontDestroyOnLoad(transform.gameObject);
    }
    else { // To destroy duplicates
      Destroy(gameObject);
    }
  }

  /*
  */
  private bool isMoving;

  void Update() {
    isMoving = false;

    // Basic movement of player
    if(Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f) {
      rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal")*moveSpeed, rb.velocity.y);
      isMoving = true;
      lastMove = new Vector2(0f, Input.GetAxisRaw("Horizontal"));
    }

    if(Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f) {
      rb.velocity = new Vector2(rb.velocity.x, Input.GetAxisRaw("Vertical")*moveSpeed);
      isMoving = true;
      lastMove = new Vector2(0f, Input.GetAxisRaw("Vertical"));
    }

    // So player doesn't keep sliding
    if(Input.GetAxisRaw("Horizontal") < 0.5f && Input.GetAxisRaw("Horizontal") > -0.5f) {
      rb.velocity = new Vector2(0f, rb.velocity.y);
    }

    if(Input.GetAxisRaw("Vertical") < 0.5f && Input.GetAxisRaw("Vertical") > -0.5f) {
      rb.velocity = new Vector2(rb.velocity.x, 0f);
    }

    /*
    anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
    anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
    anim.setBool("isMoving", isMoving);
    anim.SetFloat("LastMoveX", lastMove.x);
    anim.SetFloat("LastMoveY", lastMove.y);
    */
  }


  /*void FixedUpdate () {
    if(Input.GetKey(KeyCode.A) && transform.position == pos) {// Left
      //pos += Vector3.left;
      transform.Translate(Vector2.left*speed*Time.deltaTime);
    }
    if(Input.GetKey(KeyCode.D) && transform.position == pos) { // Right
      //pos += Vector3.right;
      transform.Translate(Vector2.right*speed*Time.deltaTime);
    }
    if(Input.GetKey(KeyCode.W) && transform.position == pos) { // Up
      //pos += Vector3.up;
      transform.Translate(Vector2.up*speed*Time.deltaTime);
    }
    if(Input.GetKey(KeyCode.S) && transform.position == pos) { // Down
      //pos += Vector3.down;
      transform.Translate(Vector2.down*speed*Time.deltaTime);
    }

    //transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);    // Move there
  }*/

}
