using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Thomas Maher
1/26/2019

Make sure to create "empty object" in scene to designate starting point
*/

public class PlayerStartingPoint : MonoBehaviour {

  private PlayerController player;
  private CameraController camera;

  public Vector2 directionFacing;

  public string pointName;

  // Use this for initialization
  void Start () {
    // move player to position of start point
    player = FindObjectOfType<PlayerController>();
    Debug.Log(player.startPoint);
    Debug.Log(pointName);
    if(player.startPoint == pointName) {
      Debug.Log(transform.position);
      player.transform.position = transform.position;

      // Fix starting position depending on the starting block for each scene
      player.lastMove = directionFacing;

      // move camera to position of start point
      camera = FindObjectOfType<CameraController>();
      camera.transform.position = new Vector3(transform.position.x, transform.position.y, camera.transform.position.z);
    }
  }
}
