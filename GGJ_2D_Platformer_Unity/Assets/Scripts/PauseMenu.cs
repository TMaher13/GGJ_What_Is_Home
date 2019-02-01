using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

  public GameObject PauseUI;

  private bool isPaused = false;

  private PlayerController player;
  private CameraController camera;

  void Start() {
    PauseUI.SetActive(false);
    player = FindObjectOfType<PlayerController>();
    camera = FindObjectOfType<CameraController>();
  }

  void Update() {
    if(Input.GetKeyDown(KeyCode.Escape)) {
      isPaused = !isPaused;
    }

    if(isPaused) {
      PauseUI.SetActive(true);
      Time.timeScale = 0; // lock the game
    }
    else {
      PauseUI.SetActive(false);
      Time.timeScale = 1;
    }
  }

  public void ResumeGame() {
    isPaused = false;
  }

  public void GoToMainMenu() {
    SceneManager.LoadScene("MainMenuScene");
    Destroy(player.gameObject);
    Destroy(camera.gameObject);
  }

  public void QuitGame() {
    Application.Quit();
  }
}
