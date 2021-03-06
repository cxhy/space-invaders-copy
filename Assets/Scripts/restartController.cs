﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restartController : MonoBehaviour {
	private bool restartingHandled = false;
	private bool reinited = false;

	// Use this for initialization
	void Start () {
		reinit ();
	}
	
	// Update is called once per frame
	void Update () {
		var player = FindObjectOfType<playerController> ();
		if (player.died && !restartingHandled) {
			gameObject.transform.position = new Vector3 (
				gameObject.transform.position.x - 999f,
				gameObject.transform.position.y,
				gameObject.transform.position.z
			);
			reinited = false;
			restartingHandled = true;
		}
	}

	public void reinit() {
		if (reinited == false) {
			gameObject.transform.position = new Vector3 (
				gameObject.transform.position.x + 999f,
				gameObject.transform.position.y,
				gameObject.transform.position.z
			);
			reinited = true; 
			restartingHandled = false;
		}
	}
}
