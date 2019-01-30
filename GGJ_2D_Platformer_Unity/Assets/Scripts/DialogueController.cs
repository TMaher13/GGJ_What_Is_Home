using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
Thomas Maher
1/25/2019
*/

public class DialogueController : MonoBehaviour {

  public GameObject dBox;
  public Text dText;

  public bool dialogueActive;

  void Start () {
    dBox.SetActive(false);
    dialogueActive = false;
  }

  void Update () {
    if(Input.GetKeyDown(KeyCode.Return)) {
      dBox.SetActive(false);
      dialogueActive = false;
    }
  }

  public void ShowBox(string dialogue) {
    Debug.Log("Got to dialogue");
    dialogueActive = true;
    dBox.SetActive(true);
    dText.text = dialogue;
  }
}
