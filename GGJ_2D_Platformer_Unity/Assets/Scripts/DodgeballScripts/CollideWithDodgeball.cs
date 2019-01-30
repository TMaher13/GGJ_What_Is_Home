using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Thomas Maher

Updated 1/29/19
*/

public class CollideWithDodgeball : MonoBehaviour {
    private DialogueController dMan;

    void Start() {
      dMan = FindObjectOfType<DialogueController>();
    }

    void Update() {
      if(dMan == null) {
         // Need to re-find dialogue manager for dodgeball scene
        dMan = FindObjectOfType<DialogueController>();
      }
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "Dodgeball") {
            //Debug.Log("Dodgeball hit! Game over.");
            dMan.ShowBox("Hit by dodgeball! Try again!");
            transform.position = new Vector2(1.5f, -10.5f);
        }
    }
}
