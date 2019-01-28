using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundsScript : MonoBehaviour {

  private BoxCollider2D bounds;
  private CameraController camera;

  // Use this for initialization
  void Start () {
    bounds = GetComponent<BoxCollider2D>();
    camera = FindObjectOfType<CameraController>();
    camera.SetBounds(bounds);
  }

  // Update is called once per frame
  void Update () {

  }
}
