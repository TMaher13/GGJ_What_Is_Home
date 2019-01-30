using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogFind : MonoBehaviour
{
    private Transform target;
    public float speed;
    public float stopDist;

    private Animator anim;

    private PlayerController player;
    private DogController doggo;
    private SpriteRenderer doggoSprite;
    //private Rigidbody2D rb;

  void Start () {
    doggo = FindObjectOfType<DogController>();
    player = FindObjectOfType<PlayerController>();
    anim = GetComponent<Animator>();
    doggoSprite = GetComponent<SpriteRenderer>();
    //rb = GetComponent<Rigidbody2D>();
  }

  void Update () {
    if(doggo.isFound) {
      if(Vector3.Distance(transform.position, player.transform.position) > 1.2f) {
        transform.position = Vector2.MoveTowards(transform.position, target.position, 2*Time.deltaTime);

        anim.SetFloat("MoveX", transform.position.x - player.transform.position.x);
        //anim.SetFloat("MoveY", moveY);
        anim.SetBool("isMoving", true);
      }

      //if(rb.velocity.x < 0)
        //doggoSprite.flipX = true;
      //else
        //doggoSprite.flipX = false;
    }
  }

  void OnTriggerEnter2D(Collider2D collision) {

        if(collision.gameObject.name == "Player") {
          target = collision.GetComponent<Transform>();
          doggo.isFound = true;
          //Invoke("DogController.stopMoving()", 0f);
          if(Vector2.Distance(transform.position, target.position) > stopDist)
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
          doggoSprite.flipX = true;
        }
    }
}
