using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class cameraMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		foreach (GameObject current in GameObject.FindGameObjectsWithTag("Player")) {
			transform.position = new Vector3 (current.transform.position.x, current.transform.position.y, transform.position.z);
		}

	}

}
