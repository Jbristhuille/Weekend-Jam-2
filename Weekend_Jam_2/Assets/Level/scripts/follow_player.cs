﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_player : MonoBehaviour {
  public float offsetX = 0;
  public float offsetY = 0;

  private GameObject player;

  // Start is called before the first frame update
  void Start() {
    player = GameObject.Find("Player");
  }

  // Update is called once per frame
  void Update() {
    float x = player.transform.position.x;
    float y = player.transform.position.y;

    gameObject.transform.position = new Vector3(x + offsetX, y + offsetY, -10);
  }
}
