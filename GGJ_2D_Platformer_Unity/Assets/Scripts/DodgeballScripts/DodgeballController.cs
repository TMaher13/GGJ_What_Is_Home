using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgeballController : MonoBehaviour {

  public float speed; // Make this a negative number
  public float delay; // For different levels

  public static int isStillPlaying;

  private Rigidbody2D rb; // rigidBody of dodgeball

  public GameObject startTile;

  // Use this for initialization
  void Start () {
    StartCoroutine(delayBalls());

    rb = GetComponent<Rigidbody2D>();
    isStillPlaying = 1;

    rb.velocity = new Vector2(speed, 0f);
  }

  IEnumerator delayBalls() {
    yield return new WaitForSeconds(delay);
  }

  // Update is called once per frame
  void Update () {

    if(isStillPlaying == 0)
      Destroy(gameObject);

  }

  // Once dodgeball leaves screen
  void OnBecameInvisible() {
    transform.position = startTile.transform.position;
    rb.velocity = new Vector2(speed, 0f);
  }
}
