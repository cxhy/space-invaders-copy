﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreUpdator : MonoBehaviour {
	private invadersController invadersController;
	// Use this for initialization
	void Start () {
		invadersController = FindObjectOfType<invadersController> ();
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text> ().text = "Your Score: " + invadersController.score.ToString ();
	}
}
