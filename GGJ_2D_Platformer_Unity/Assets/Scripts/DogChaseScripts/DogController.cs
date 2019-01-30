using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class DogController : MonoBehaviour
{
    public float speed;
    //Transform currentPoint;
    private Animator anim;
    //public Vector2 lastMove;
    private bool isMoving;

    private Vector3 nextPoint;

    private char tagChar;

    public bool isFound;

    void Start() {
      anim = GetComponent<Animator>();
      //agent = GetComponent<NavMeshAgent>();
      isFound = false;
      tagChar = '1';
    }

    private void Update()
    {
      if(!isFound) {
        switch(tagChar) {
          case '1':
            //transform.position = Vector3.MoveTowards(transform.position, new Vector3(32.4f, 21.35f, 0f), speed*Time.deltaTime);
            nextPoint = new Vector3(32.4f, 21.35f, 0f);
            if(Vector3.Distance(transform.position, new Vector3(32.4f, 21.35f, 0f)) < .1f) tagChar = '2';
            break;
          case '2':
            //transform.position = Vector3.MoveTowards(transform.position, new Vector3(32.87f, 2.59f, 0f), speed*Time.deltaTime);
            nextPoint = new Vector3(32.87f, 2.59f, 0f);
            if(Vector3.Distance(transform.position, new Vector3(32.87f, 2.59f, 0f)) < .5f) tagChar = '3';
            break;
          case '3':
            //transform.position = Vector3.MoveTowards(transform.position, new Vector3(21.9f, 6.45f, 0f), speed*Time.deltaTime);
            nextPoint = new Vector3(21.9f, 6.45f, 0f);
            if(Vector3.Distance(transform.position, new Vector3(21.9f, 6.45f, 0f)) < .5f) tagChar = '4';
            break;
          case '4':
            //transform.position = Vector3.MoveTowards(transform.position, new Vector3(10.93f, 11.67f, 0f), speed*Time.deltaTime);
            nextPoint = new Vector3(10.93f, 11.67f, 0f);
            if(Vector3.Distance(transform.position, new Vector3(10.93f, 11.67f, 0f)) < .5f) tagChar = '5';
            break;
          case '5':
            //transform.position = Vector3.MoveTowards(transform.position, new Vector3(10.52f, 27.38f, 0f), speed*Time.deltaTime);
            nextPoint = new Vector3(10.52f, 27.38f, 0f);
            if(Vector3.Distance(transform.position, new Vector3(10.52f, 27.38f, 0f)) < .5f) tagChar = '6';
            break;
          case '6':
            //transform.position = Vector3.MoveTowards(transform.position, new Vector3(22.31f, 27.65f, 0f), speed*Time.deltaTime);
            nextPoint = new Vector3(22.31f, 27.65f, 0f);
            if(Vector3.Distance(transform.position, new Vector3(22.31f, 27.65f, 0f)) < .5f) tagChar = '7';
            break;
          case '7':
            //transform.position = Vector3.MoveTowards(transform.position, new Vector3(17.7f, 19.79f, 0f), speed*Time.deltaTime);
            nextPoint = new Vector3(17.7f, 19.79f, 0f);
            if(Vector3.Distance(transform.position, new Vector3(17.7f, 19.79f, 0f)) < .5f) tagChar = '1';
            break;
        }

        transform.position = Vector3.MoveTowards(transform.position, nextPoint, speed*Time.deltaTime);

        float xDiff = transform.position.x - nextPoint.x;
        float yDiff = transform.position.y - nextPoint.y;
        float moveX, moveY;

        if(Mathf.Abs(xDiff) > Mathf.Abs(yDiff)) {
          moveX = xDiff / Mathf.Abs(xDiff);
          moveY = 0;
          //lastMove = new Vector2(moveX, 0f);
        }
        else {
          moveY = yDiff / Mathf.Abs(yDiff);
          moveX = 0;
          //lastMove = new Vector2(0f, moveY);
        }


        anim.SetFloat("MoveX", moveX);
        //anim.SetFloat("MoveY", moveY);
        anim.SetBool("isMoving", true);
        //anim.SetFloat("LastMoveX", lastMove.x);
        //anim.SetFloat("LastMoveY", lastMove.y);
      }
    }

    void stopMoving() {
        speed = 0;
    }
}
