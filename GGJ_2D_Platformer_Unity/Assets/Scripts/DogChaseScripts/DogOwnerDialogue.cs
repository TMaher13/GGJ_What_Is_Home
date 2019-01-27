using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

/*
Thomas Maher
1/25/2019
*/

public class DogOwnerDialogue : MonoBehaviour {

  //public string dialogue;
  private string defaultMessage;
  private DialogueController dMan;

  private DogController doggo;
  private PlayerController player;

  public bool isDefault; // Needs to be changed by external object

  // Use this for initialization
  void Start () {
    dMan = FindObjectOfType<DialogueController>();
    doggo = FindObjectOfType<DogController>();
    player = FindObjectOfType<PlayerController>();

    defaultMessage = "Karen: I've lost my dog :( Would you please help me get her back?";
    isDefault = true;
  }

  // Update is called once per frame
  void Update () {
    if(doggo.isFound)
      isDefault = false;
  }

  void OnMouseDown() {

    if(isDefault)
      dMan.ShowBox(defaultMessage);
    else {
      dMan.ShowBox("Karen: Thank you so much! I found this item of yours while you were finding my dog, I think you\'ll want it");
      player.progress++;
    }
  }
}
