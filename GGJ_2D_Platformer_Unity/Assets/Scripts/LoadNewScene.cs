using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
Thomas Maher
1/26/2019

Create gameObject and set trigger on
*/

public class LoadNewScene : MonoBehaviour {

  public string newScene;

  /*
  File => Build Settings
  Make sure Scenes are in Build
  */

  void OnTriggerEnter2D(Collider2D other) {

    if(other.gameObject.name == "Player") {
      SceneManager.LoadScene(newScene);
    }
  }
}
