using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogFind : MonoBehaviour
{
    private Transform target;
    public float speed;
    public float stopDist;

    private PlayerController player;
    private DogController doggo;
    private SpriteRenderer doggoSprite;

  // Use this for initialization
  void Start () {

    doggo = GetComponent<DogController>();
    player = FindObjectOfType<PlayerController>();
    doggoSprite = GetComponent<SpriteRenderer>();

  }

  // Update is called once per frame
  void Update () {
    if(doggo.isFound) {
      if(Vector3.Distance(transform.position, player.transform.position) > 1.2f)
        transform.position = Vector2.MoveTowards(transform.position, target.position, 2*Time.deltaTime);

      if(player.transform.position.x < transform.position.x)
        doggoSprite.flipX = true;
      else
        doggoSprite.flipX = false;

    }
  }

  void OnTriggerEnter2D(Collider2D collision) {

        if(collision.gameObject.name == "Player") {
          target = collision.GetComponent<Transform>();
          doggo.isFound = true;
          //Invoke("DogController.stopMoving()", 0f);
          if(Vector2.Distance(transform.position, target.position) > stopDist)
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}
