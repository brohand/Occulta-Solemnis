using UnityEngine;
using System.Collections;

public class NPCclass : MonoBehaviour {

	public nodeObj myNode;
	private bool reverse = true;
	public float civSpeed = 1f;
	public string myName;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		walkPath (myNode);
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.tag == "backNodes" && gameObject.tag != "nullTriggs") {
			//print("Triggered.");	
			transferNode ();
		}
	}

	void OnCollisionEnter2D (Collision2D other) {
		if (other.gameObject.tag == "Player") {
			GameObject.FindGameObjectWithTag ("Detective").GetComponent<Alert> ().alert = true;
		}
	}

	void walkPath (nodeObj currentNode) {
		

		if (currentNode != null) {
			//transform.position = Vector3.MoveTowards (transform.position, currentNode.transform.position, civSpeed/10); 
			this.GetComponent<Rigidbody2D> ().velocity = (myNode.transform.position - transform.position).normalized * 2f;
			//Vector2 direction = (GameObject.FindGameObjectWithTag("Player").transform.position - transform.position);
			//this.GetComponent<Rigidbody2D> ().AddForce (direction * civSpeed);
		}
	}

	void transferNode() {
		if (myNode.edgeNode == true) {
			if (reverse == true) {
				reverse = false;
			} else {
				reverse = true;
			}
		}

		if (reverse == false) {
			myNode = myNode.next;
		} else {
			myNode = myNode.prev;
		}
	}

	public void interruptPhase() {
		//StopCoroutine ("walkPath");
		//print("Test.");
		//StartCoroutine("walkPath");
	}
}
	