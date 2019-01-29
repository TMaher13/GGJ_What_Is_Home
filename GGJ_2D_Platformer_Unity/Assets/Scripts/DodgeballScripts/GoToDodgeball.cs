using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
Thomas Maher

Updated 1/29/19
*/

public class GoToDodgeball : MonoBehaviour {
    private PlayerController player;
    private DialogueController dMan;

    // Which stage the player is at in the game
    public static int progress;

    private bool sendToGame;

    // Use this for initialization
    void Start() {
      dMan = FindObjectOfType<DialogueController>();
      player = FindObjectOfType<PlayerController>();
      sendToGame = false;
    }

    void OnTriggerEnter2D() {
      if(player.progress < 2) {
        dMan.ShowBox("Jimmy: I have something of yours! If you want it, you have to beat us in dodgeball!");
        sendToGame = true;
      }
      else
        dMan.ShowBox("Jimmy: Thanks for playing us in dodgeball!");
    }

    void Update() {
      if(sendToGame) {
        StartCoroutine("WaitForDodgeball");
      }
    }

    IEnumerator WaitForDodgeball() {

      while(!Input.GetKeyDown(KeyCode.Return)) {
        yield return null;
      }

      SceneManager.LoadScene("DodgeballGame");
      player.transform.position = new Vector2(1.5f, -10.5f);
    }
}
