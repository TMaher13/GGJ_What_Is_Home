using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogFind : MonoBehaviour 
{
    private Transform target;
    public float speed;
    public float stopDist;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        target = collision.GetComponent<Transform>();

        if(target.CompareTag("Player") == true)
        {
            Invoke("DogController.stopMoving()", 0f);
            if(Vector2.Distance(transform.position, target.position) > stopDist)
                transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}
