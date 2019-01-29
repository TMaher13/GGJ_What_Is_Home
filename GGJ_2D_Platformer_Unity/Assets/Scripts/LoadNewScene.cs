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

  public string exitPoint;

  private PlayerController player;
  private DialogueController dMan;

  /*
  File => Build Settings
  Make sure Scenes are in Build
  */

  void Start() {
    player = FindObjectOfType<PlayerController>();
    dMan = FindObjectOfType<DialogueController>();
  }

  void OnTriggerEnter2D(Collider2D other) {

    if(other.gameObject.name == "Player") {

      if(newScene == "EndScene" && player.progress != 2) {
        dMan.ShowBox("Wait! You haven't finished all the challenges yet!");
      }
      else {
        SceneManager.LoadScene(newScene);
        player.startPoint = exitPoint;
      }
    }
  }
}
