using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Thomas Maher

1/28/19
*/

public class BoundsScript : MonoBehaviour {

  private BoxCollider2D bounds;
  private CameraController camera;

  void Start () {
    bounds = GetComponent<BoxCollider2D>();
    camera = FindObjectOfType<CameraController>();
    camera.SetBounds(bounds);
  }

  // Update is called once per frame
  void Update () {

  }
}
