using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class DogController : MonoBehaviour
{

    //public Transform[] points;
    //private int destPoint;
    //private NavMeshAgent agent;
    public float speed;
    //Transform currentPoint;
    private Animator anim;
    public Vector2 lastMove;
    private bool isMoving;

    private Vector3 nextPoint;

    private char tagChar;

    public bool isFound;

    void Start()
    {
      anim = GetComponent<Animator>();
        //agent = GetComponent<NavMeshAgent>();
      isFound = false;
      tagChar = '1';

        // makes continuous movement
        //agent.autoBraking = false;

        //destPoint = 0;
        //currentPoint = points[destPoint];

        //GotoNextPoint();
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

        //Debug.Log(moveX);
        //Debug.Log(moveY);

        anim.SetFloat("MoveX", moveX);
        anim.SetFloat("MoveY", moveY);
        anim.SetBool("isMoving", true);
        anim.SetFloat("LastMoveX", lastMove.x);
        anim.SetFloat("LastMoveY", lastMove.y);

      }
    }

    /*void OnTriggerEnter2D(Collider2D other) {
      if(other.gameObject.CompareTag("dogPoint")) {
        destPoint++;
        currentPoint = points[destPoint];
      }
    }*/

    void GotoNextPoint()
    {
        //transform.Translate(Vector3.up * Time.deltaTime * speed);
        //transform.position = Vector3.MoveTowards(transform.position, points[destPoint].position, speed*Time.deltaTime);





        // choose next point, or cycle through
        //destPoint = (destPoint + 1) % points.Length;

        /*if(Vector3.Distance(transform.position, currentPoint.position) < .1f)
        {
            if (destPoint + 1 < points.Length)
            {
                destPoint++;
                Debug.Log("Hit a sprite");
            }
            else
            {
                destPoint = 0;
            }
            currentPoint = points[destPoint];
        }*/

        /*Vector3 pointDir = currentPoint.position - transform.position;
        float angle = Mathf.Atan2(pointDir.y, pointDir.x) * Mathf.Rad2Deg - 90f;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, q, 10f);
        */
    }

    void stopMoving()
    {
        speed = 0;
    }
}
