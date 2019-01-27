using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*
Thomas Maher
1/25/2019
*/

public class CameraController : MonoBehaviour {

  private static bool cameraExists;

  public GameObject player;
  private Vector3 playerPos;
  public float moveSpeed; // How fast we want camera to move. 5 is roughly a good value (maybe a little less)

  void start() {
        //DontDestroyOnLoad(transform.gameObject);

    if(!cameraExists) {
      cameraExists = true;
      // So that player exists when switching between scenes/levels
      DontDestroyOnLoad(transform.gameObject);
    }
    else { // To destroy duplicates
      Destroy(gameObject);
    }
  }

  void Update() 
    {
        playerPos = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, playerPos, moveSpeed * Time.deltaTime); // Camera follows the player but 6 to the right
    }
}
