using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DetectiveClass : MonoBehaviour {

    // Use this for initialization
    public Vector2 myLastLocation;
	public nodeObj myCopNode;
	private bool myReverse = true;
	public float detectSpeed = 100f;

	//private bool isDetective;

	void Start () {
        myLastLocation = new Vector2(0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if (this.GetComponent<Alert> ().alert == false) {
			walkPath (myCopNode);
		} else {
			transform.position = Vector3.MoveTowards (transform.position, GameObject.FindGameObjectWithTag("Player").transform.position, 0.07f); 
			//addNode((Vector2)(GameObject.FindGameObjectWithTag("Player").transform.position));
			//this.GetComponent<Alert> ().alert = false;
			//Vector2 direction = (GameObject.FindGameObjectWithTag("Player").transform.position - transform.position);
			//this.GetComponent<Rigidbody2D> ().AddForce (direction * detectSpeed);
		}
	}

	void OnCollisionEnter2D (Collision2D other) {
		if (other.gameObject.tag == "Player") {
			SceneManager.LoadScene (3, LoadSceneMode.Single);
		}
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.tag == "backNodes" && gameObject.tag != "nullTriggs") {
		//if (other.gameObject == myCopNode.next) {
			//print ("Triggered:" + other.gameObject.name);	
			transferNode ();
	
		}
	}

	void walkPath (nodeObj currentNode) {
		if (currentNode != null) {
			//transform.position = Vector3.MoveTowards (transform.position, currentNode.transform.position, detectSpeed/10); 
			this.GetComponent<Rigidbody2D> ().velocity = (myCopNode.transform.position - transform.position).normalized * 3f;
		}
	}

	void transferNode() {
		if (myCopNode.edgeNode == true) {
			if (myReverse == true) {
				myReverse = false;
			} else {
				myReverse = true;
			}
		}

		if (myReverse == false) {
			myCopNode = myCopNode.next;
		} else {
			myCopNode = myCopNode.prev;
		}
	}

	//void interruptPhase() {
		//StopCoroutine ("walkPath");
		//StartCoroutine("walkPath");
	//}

	public void addNode(Vector2 location) {
		nodeObj newPoint = (nodeObj)Instantiate (Resources.Load("node"), location, Quaternion.identity);
		newPoint.GetComponent<nodeObj> ().next = myCopNode;
		newPoint.GetComponent<nodeObj> ().prev = myCopNode.prev;
		//newPoint.next = myCopNode;
		//newPoint.prev = myCopNode.prev;

		myCopNode = newPoint;
		//this.GetComponentInParent<NPCclass>().interruptPhase ();
		//interruptPhase();
	}
}
