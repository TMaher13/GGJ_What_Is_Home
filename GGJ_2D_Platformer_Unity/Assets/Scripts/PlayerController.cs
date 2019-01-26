using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

  public float moveSpeed;

  // for flipping

  // variables to deal with player body
  private Rigidbody2D rb;
  //public SpriteRenderer sr; //drag and drop the sprite rendere of your player from inscpector to the script.

  private Vector3 pos; // For movement
  private float speed = 2.0f; // Speed of movement

  void Start () {
    pos = transform.position; // Take the initial position
  }

  void FixedUpdate () {
    if(Input.GetKey(KeyCode.A) && transform.position == pos) {// Left
      pos += Vector3.left;
      //sr.flipX = true;
    }
    if(Input.GetKey(KeyCode.D) && transform.position == pos) { // Right
      pos += Vector3.right;
      //sr.flipX = false;
    }
    if(Input.GetKey(KeyCode.W) && transform.position == pos) // Up
      pos += Vector3.up;
    if(Input.GetKey(KeyCode.S) && transform.position == pos) // Down
      pos += Vector3.down;

    transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);    // Move there
  }

}
