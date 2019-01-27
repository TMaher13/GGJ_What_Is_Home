using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Thomas Maher
1/25/2019
*/

public class CameraController : MonoBehaviour {

  private static bool cameraExists;

  public GameObject player;
  private Vector3 playerPos;
  public float moveSpeed; // How fast we want camera to move. 5 is roughly a good value (maybe a little less)

  public BoxCollider2D boundBox;
  private Vector3 minBounds;
  private Vector3 maxBounds;

  private Camera camera;
  private float halfHeight;
  private float halfWidth;

  void Start() {
    //DontDestroyOnLoad(transform.gameObject);
    //player = FindObjectOfType<PlayerController>();

    if(!cameraExists) {
      cameraExists = true;
      // So that player exists when switching between scenes/levels
      DontDestroyOnLoad(transform.gameObject);
    }
    else { // To destroy duplicates
      Destroy(gameObject);
    }

    minBounds = boundBox.bounds.min;
    maxBounds = boundBox.bounds.max;

    camera = GetComponent<Camera>();
    halfHeight = camera.orthographicSize;
    halfWidth = halfHeight * Screen.width / Screen.height;

  }

  void Update() {

    playerPos = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
    transform.position = Vector3.Lerp(transform.position, playerPos, moveSpeed * Time.deltaTime); // Camera follows the player but 6 to the right


    if(boundBox == null) {
      boundBox = FindObjectOfType<BoundsScript>().GetComponent<BoxCollider2D>();
      minBounds = boundBox.bounds.min;
      maxBounds = boundBox.bounds.max;
    }
    float clampedX = Mathf.Clamp(transform.position.x, minBounds.x + halfWidth, maxBounds.x - halfWidth);
    float clampedY = Mathf.Clamp(transform.position.y, minBounds.y + halfHeight, maxBounds.y - halfHeight);
    transform.position = new Vector3(clampedX, clampedY, transform.position.z);
  }

  public void SetBounds(BoxCollider2D newBounds) {
    boundBox = newBounds;

    minBounds = boundBox.bounds.min;
    maxBounds = boundBox.bounds.max;
  }
}
