using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class DogController : MonoBehaviour
{

    public Transform[] points;
    private int destPoint;
    //private NavMeshAgent agent;
    public float speed;
    Transform currentPoint;


    void Start()
    {
        //agent = GetComponent<NavMeshAgent>();

        // makes continuous movement
        //agent.autoBraking = false;

        destPoint = 0;
        currentPoint = points[destPoint];

        //GotoNextPoint();
    }

    private void Update()
    {
        GotoNextPoint();
    }

    void GotoNextPoint()
    {
        // if no points have been made
        if (points.Length == 0)
            return;

        // go to selected point
        //agent.destination = points[destPoint].position;

        //move to point
        transform.Translate(Vector3.up * Time.deltaTime * speed);

        // choose next point, or cycle through
        //destPoint = (destPoint + 1) % points.Length;

        if (Vector3.Distance(transform.position, currentPoint.position) < .1f)
        {
            if (destPoint + 1 < points.Length)
            {
                destPoint++;
            }
            else
            {
                destPoint = 0;
            }
            currentPoint = points[destPoint];
        }

        Vector3 pointDir = currentPoint.position - transform.position;
        float angle = Mathf.Atan2(pointDir.y, pointDir.x) * Mathf.Rad2Deg - 90f;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, q, 10f);
    }

    void stopMoving()
    {
        speed = 0;
    }
}