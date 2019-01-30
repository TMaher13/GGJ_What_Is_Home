using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

/*
Thomas Maher
1/25/2019
*/

public class NPCisCLicked : MonoBehaviour {

  public string dialogue;
  private DialogueController dMan;

  // Use this for initialization
  void Start () {
    dMan = FindObjectOfType<DialogueController>();
  }

  void Update () {
  }

  void OnMouseDown() {
    dMan.ShowBox(dialogue);
  }
}
