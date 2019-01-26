using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgeballsMove : MonoBehaviour {

  public float speed; // Make this a negative number
  public float getHarder; // set to something like 1.1 or 1.05

  public static bool isStillPlaying;
  public static float score;
  private float oldScore; // to compare to see if balls should move faster

  private Rigidbody2D rb; // rigidBody of dodgeball

  public GameObject startTile;

  // Use this for initialization
  void Start () {
    rb = GetComponent<Rigidbody2D>();
    oldScore = 0f;
    isStillPlaying = true;

    rb.velocity = new Vector2(0f, speed);
  }

  // Update is called once per frame
  void Update () {
    if(score > oldScore) {
      oldScore = score;
      speed *= getHarder;
    }

    if(!isStillPlaying)
      Destroy(gameObject);

  }

  // Once dodgeball leaves screen
  void OnBecameInvisible() {
    score++;

    if(score < 10) { // continue game
      transform.position = startTile.transform.position;
      rb.velocity = new Vector2(0f, speed);
    }
    else
      Destroy(gameObject);
  }
}
