using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {

    // Use this for initialization
    public bool holding;
    public bool itemFound;
    public GameObject heldItem;
    public GameObject currItem;
	void Start () {
        holding = false;

	}
	
	// Update is called once per frame
	void Update () {
      
       
            if (Input.GetButtonDown("Fire1"))
            {
                if (itemFound && !holding)
                {
                    if(currItem.gameObject.GetComponent<itemScript>().inCircle == false)
                    pickUp(currItem);
                }
                else if (holding)
                    putDown();
            }
         
	
	}
     void OnTriggerExit2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Item")
        {
            itemFound = false;
            currItem = null;
        }
    }
    void OnTriggerStay2D(Collider2D coll)
    {
        //print("collision");
        if(coll.gameObject.tag == "Item")
        {
            itemFound = true;
            currItem = coll.gameObject;
             
            
        }
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Ritual")
        {
            if (holding)
            {
                Invoke("putDown", 0.5f);
                coll.gameObject.GetComponent<ItemDetection>().itemsPlaced++;
                heldItem.gameObject.GetComponent<itemScript>().inCircle = true;

            }
        }
    }

    void pickUp(GameObject gameObj)
    {
        
        
        heldItem = gameObj;
        holding = true;
        heldItem.GetComponent<AudioSource>().Play();
        gameObj.transform.Translate(0, 1000, 0); //Moves realllllyyyyy far away
        
    }

    void putDown()
    {
        if (heldItem != null && holding) {
            
            heldItem.transform.position = transform.position;
            heldItem.GetComponent<AudioSource>().Play();
            holding = false;
            heldItem = null;
            
        }
    }
}
