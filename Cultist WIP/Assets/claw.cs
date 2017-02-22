using UnityEngine;
using System.Collections;

public class claw : MonoBehaviour {
	public Sprite[] mySprites;
	public int fps = 3;
	private bool done;

	void Start () {
		done = false;
	}
	
	// Update is called once per frame
	void Update () {
		int index = 0;
		if (!done) {
			index = (int)((Time.time * fps) % mySprites.Length);
			this.GetComponent<SpriteRenderer> ().sprite = mySprites [index];
		}
		if (index == 15) {
			done = true;
		}
	}
}


//var frames : Texture[];
//var framesPerSecond = 10;
//
//function Update() {
//	var index : int = (Time.time * framesPerSecond) % frames.Length;
//	renderer.material.mainTexture = frames[index];
//}