using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public static bool gameStarted = false;

    public GameObject mainMenuUI;

    public Button NewGameButton;

  // Use this for initialization
  void Start () {
    NewGameButton.onClick.AddListener(startNewGame);
  }

  void startNewGame() {
    SceneManager.LoadScene(sceneName: "IntroScene");
    gameStarted = true;
  }
}
