using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Thomas Maher

Updated 1/29/19
*/

public class DodgeballController : MonoBehaviour
{

    public float speed; // Make this a negative number
                        //public float delay; // For different levels
    private Vector2 startPos;

    public bool isStillPlaying;

    public static bool isStillPlaying2;

    private Rigidbody2D rb; // rigidBody of dodgeball

    public Vector2 startTile;

    // Use this for initialization
    void Start()
    {
        startPos = transform.position;

        rb = GetComponent<Rigidbody2D>();
        isStillPlaying = true;
        isStillPlaying2 = true;

        rb.velocity = new Vector2(speed, 0f);

    }

    // Update is called once per frame
    void Update()
    {
        //isStillPlaying2 = isStillPlaying;

        if (!isStillPlaying2)
            Destroy(gameObject);

        if (Mathf.Abs(startPos.x - transform.position.x) > 32f)
        {
            //Debug.Log(startTile);
            transform.position = startTile + new Vector2(4,2);
            rb.velocity = new Vector2(speed, 0f);
        }
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player") {
          transform.position = startTile + new Vector2(4,2);
          rb.velocity = new Vector2(speed, 0f);
        }
    }
}
