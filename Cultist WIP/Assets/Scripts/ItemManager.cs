using UnityEngine;
using System.Collections;

using System.Collections.Generic;

public class ItemManager : MonoBehaviour {
    public GameObject[] spawnLocs = new GameObject[7];
    public GameObject[] itemList;
    //public GameObject[] spawned = new GameObject[3];
	public List<GameObject> spawned = new List<GameObject>();
    //public GameObject[] used = new GameObject[3];
	public List<GameObject> used = new List<GameObject>();
	// Use this for initialization
	void Start () {
        itemList = Resources.LoadAll<GameObject>("Items");
        GameObject newItem;
        GameObject randLoc;

        for(int i = 0; i < 3; i++)
        {
            newItem = itemList[Random.Range(0, itemList.Length - 1)];
            randLoc = spawnLocs[Random.Range(0, spawnLocs.Length - 1)];
			while (spawned.Contains(newItem))
                newItem = itemList[Random.Range(0, itemList.Length - 1)];
			while (used.Contains(randLoc))
                randLoc = spawnLocs[Random.Range(0, spawnLocs.Length - 1)];
			spawned.Insert(i, newItem);
			used.Insert (i, randLoc);
            //spawned[i].transform.localScale = spawnLocs[i].transform.localScale;
            float newX = spawnLocs[i].transform.lossyScale.x / spawned[i].transform.lossyScale.x;
            float newY = spawnLocs[i].transform.lossyScale.y / spawned[i].transform.lossyScale.y;
            spawned[i].GetComponent<BoxCollider2D>().size = new Vector2(newX , newY);
            Instantiate(spawned[i], randLoc.transform.position, Quaternion.identity);
            
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
