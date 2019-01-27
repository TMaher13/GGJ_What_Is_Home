using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogFind : MonoBehaviour
{
    private Transform target;
    public float speed;
    public float stopDist;

    private DogController doggo;

  // Use this for initialization
  void Start () {

    doggo = GetComponent<DogController>();

  }

  // Update is called once per frame
  void Update () {
    if(doggo.isFound) {
      transform.position = Vector2.MoveTowards(transform.position, target.position, 1*Time.deltaTime);
    }
  }

  void OnTriggerEnter2D(Collider2D collision) {
        target = collision.GetComponent<Transform>();

        if(target.CompareTag("Player") == true) {
            Debug.Log("You found me!");
            doggo.isFound = true;
            //Invoke("DogController.stopMoving()", 0f);
            if(Vector2.Distance(transform.position, target.position) > stopDist)
                transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}
