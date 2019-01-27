using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuCamera : MonoBehaviour {

    public Button NewGameButton;
    public GameObject mainMenuUI;
    //public Slider Volume;

    // Use this for initialization
    void Start () {
        //SceneManager.LoadScene(sceneName: "MainMenuScene");
        NewGameButton.onClick.AddListener(newGame);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void newGame () {
        Debug.Log("Switching scenes to 'IntroScene'.");
        SceneManager.LoadScene(sceneName: "IntroScene");
    }
}
