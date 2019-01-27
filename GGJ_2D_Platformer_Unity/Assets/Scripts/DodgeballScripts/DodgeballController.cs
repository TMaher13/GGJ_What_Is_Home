using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgeballController : MonoBehaviour {

  public float speed; // Make this a negative number
  //public float delay; // For different levels
  private Vector2 startPos;

  public static bool isStillPlaying;

  private Rigidbody2D rb; // rigidBody of dodgeball

  //public GameObject startTile;

  // Use this for initialization
  void Start () {
    StartCoroutine(delayBalls());
    startPos = transform.position;
  }

  IEnumerator delayBalls() {
    //yield return new WaitForSeconds(delay);

    rb = GetComponent<Rigidbody2D>();
    isStillPlaying = true;

    rb.velocity = new Vector2(speed, 0f);
  }

  // Update is called once per frame
  void Update () {
    if(!isStillPlaying)
      Destroy(gameObject);

    if(Mathf.Abs(startPoint.x - transform.position.x) > 38f)
      transform.position = startPos;
  }
}
