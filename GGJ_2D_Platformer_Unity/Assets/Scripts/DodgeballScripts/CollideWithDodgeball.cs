using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideWithDodgeball : MonoBehaviour {

  //shared bool with dodgeballs
  public static bool isStillPlaying;

  void OnCollisionEnter(Collision collisionInfo) {
    if(collisionInfo.collider.tag == "Dodgeball") {
      Debug.Log("Dodgeball hit! Game over.");
      isStillPlaying = false;
    }
  }
}
