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
  private string defaultMessage;
  private DialogueController dMan;

  public bool isDefault; // Needs to be changed by external object

  // Use this for initialization
  void Start () {
    dMan = FindObjectOfType<DialogueController>();
    defaultMessage = "This is the default message";
    isDefault = true;
  }

  // Update is called once per frame
  void Update () {
  }

  void OnMouseDown() {

    if(isDefault)
      dMan.ShowBox(defaultMessage);
    else
      dMan.ShowBox(dialogue);
  }
}
