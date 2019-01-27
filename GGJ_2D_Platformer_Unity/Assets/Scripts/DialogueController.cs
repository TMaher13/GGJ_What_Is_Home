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

  // Use this for initialization
  void Start () {
    dBox.SetActive(true);
    dialogueActive = true;
  }

  // Update is called once per frame
  void Update () {
    if(dialogueActive && Input.GetKeyDown(KeyCode.Return)) {
      dBox.SetActive(false);
      dialogueActive = false;
    }
  }

  public void ShowBox(string dialogue) {
    dialogueActive = true;
    dBox.SetActive(true);
    dText.text = dialogue;
  }

}
