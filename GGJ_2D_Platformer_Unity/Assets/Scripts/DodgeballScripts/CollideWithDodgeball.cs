using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideWithDodgeball : MonoBehaviour
{

    //shared bool with dodgeballs
    //public static bool isStillPlaying;
    private DodgeballController dodgeball;
    //private DialogueController dMan;

    void Start()
    {
        dodgeball = GetComponent<DodgeballController>();
        //dMan = FindObjectOfType<DialogueController>();
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Dodgeball")
        {
            Debug.Log("Dodgeball hit! Game over.");
            //dMan.ShowBox("Hit by dodgeball! Try again!");
            //dodgeball.isStillPlaying = true;
            //Invoke("DodgeballController.isStillPlaying", 0);
            transform.position = new Vector2(1.5f, -10f);
        }
    }
}