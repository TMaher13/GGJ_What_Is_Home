using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour {

  private static bool pauseExists;

  // Use this for initialization
  void Start () {
    if(!pauseExists) {
      pauseExists = true;
      // So that player exists when switching between scenes/levels
      DontDestroyOnLoad(transform.gameObject);
    }
    else { // To destroy duplicates
      Destroy(gameObject);
    }
  }
}
