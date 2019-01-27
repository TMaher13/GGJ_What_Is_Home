using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToDodgeball : MonoBehaviour {

  private DialogueController dMan;
  private PlayerController player;

  // Which stage the player is at in the game
  public static int progress;

  // Use this for initialization
  void Start () {
    dMan = FindObjectOfType<DialogueController>();
    player = FindObjectOfType<PlayerController>();
  }

  void OnMouseDown() {

    if(player.progress < 3)
      dMan.ShowBox("Jimmy: I hear Mrs. Lavery is having a yard sale!");
    else if(player.progress == 3) {
      dMan.ShowBox("Jimmy: I have something of yours! If you want it, you have to beat us in dodgeball!");

      // Wait until they press space
      while(!Input.GetKeyDown(KeyCode.Space)) {};

      //SceneManager.LoadScene("DodgeballGame");
    }
    else
      dMan.ShowBox("Jimmy: Did you talk to Billy to get your item back?");

  }
}
