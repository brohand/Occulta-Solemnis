using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ItemDetection : MonoBehaviour {
    public int desired = 3;
    public int itemsPlaced;
	// Use this for initialization
	void Start () {
        itemsPlaced = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if(itemsPlaced >= 3)
        {
            Win();
        }
	
	}
     
    void onTriggerEnter2D(Collider2D coll)
    {
       
    }

    void Win()
    {
        //Something happens here 
        SceneManager.LoadScene(2, LoadSceneMode.Single);

    }
}
