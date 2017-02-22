using UnityEngine;
using System.Collections;

public class nodeObj : MonoBehaviour {

	public nodeObj next;
	public nodeObj prev;
	public bool edgeNode;

	//var target : Transform;
	void OnDrawGizmos () {
		if(next != null) {
			if (edgeNode == false) {
				Gizmos.color = Color.blue;
				Gizmos.DrawLine (transform.position, next.transform.position);
			} else if (edgeNode == true && next.edgeNode == true) {
				Gizmos.color = Color.red;
				Gizmos.DrawLine (transform.position, next.transform.position);
			} else {
				Gizmos.color = Color.blue;
				Gizmos.DrawLine (transform.position, next.transform.position);
			}

		}
	}

}
