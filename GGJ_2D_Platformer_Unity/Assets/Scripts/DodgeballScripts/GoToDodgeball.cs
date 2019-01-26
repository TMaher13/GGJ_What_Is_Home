using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToDodgeball : MonoBehaviour {

  private string dialogue;
  private string defaultMessage;
  private DialogueController dMan;

  // Which stage the player is at in the game
  public static int progress;

  // Use this for initialization
  void Start () {
    dMan = FindObjectOfType<DialogueController>();

    defaultMessage = "I hear Mrs. Lavery is having a yard sale!";
    dialogue = "I have something of yours! If you want it, you have to beat us in dodgeball!";
  }

  void OnMouseDown() {

    if(progress < 3)
      dMan.ShowBox(defaultMessage);
    else {
      dMan.ShowBox(dialogue);

      // Wait until they press space
      while(!Input.GetKeyDown(KeyCode.Space)) {};

      SceneManager.LoadScene("DodgeballGame");
    }
  }
}
