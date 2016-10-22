using UnityEngine;
using System.Collections;

public class mirada : MonoBehaviour, IGvrGazeResponder {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnGazeEnter () {
		GetComponent<MeshRenderer> ().material.color = Color.magenta;
	}

	public void OnGazeExit () {
		GetComponent<MeshRenderer> ().material.color = Color.white;
	}

	public void OnGazeTrigger () {
	}
}
