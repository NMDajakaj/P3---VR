﻿using UnityEngine;
using System.Collections;

public class Click : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void pulsaClick () {
		this.GetComponent<MeshRenderer> ().material.color = Color.red;
	}
}
