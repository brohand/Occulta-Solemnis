using UnityEngine;
using System.Collections;

public class NPCLineOfSight : MonoBehaviour {

    Rigidbody2D rb2d;
//    Vector2 dir;
//    public float maxTimer = 10f;
//    float timer;
//    float rot;
//    float offX;
//    float offY;
    //public GameObject vision;
    // Use this for initialization
    void Start()
    {
		rb2d = GameObject.FindWithTag("Detective").GetComponent<Rigidbody2D>();
//        dir = rb2d.velocity;
//        rot = 0f;
//        offX = 0f;
//        offY = 0f;
    }

    // Update is called once per frame
    void Update()
    {
//        if (dir.x > 0)
//        {
//            rot = 90;
//            offX = -3.1f;
//            offY = -0.6f;
//        }
//        else if (dir.x < 0)
//        {
//            rot = 90;
//            offX = -3.1f;
//            offY = 0.6f;
//        }
//        else if (dir.y > 0)
//        {
//            rot = 0;
//            offX = 0;
//            offY = 0;
//
//        }
//        else if (dir.y < 0)
//        {
//            rot = 0;
//            offX = 0;
//            offY = -1.35f;
//        }

        //transform.rotation = Quaternion.Euler(0, 0, rot);
        //GetComponent<BoxCollider2D>().offset = new Vector2(offX, offY);
		//transform.position = new Vector3 (rb2d.transform.position.x, rb2d.transform.position.y, rb2d.transform.position.z);

    }

//    void OnTriggerEnter2D(Collider2D coll)
//    {
//        if (coll.gameObject.tag == "Player")
//        {
//            //print("PLAYER FOUND");
//            timer = 0;
//        }
//
//    }
//    void OnTriggerStay2D(Collider2D coll)
//    {
//        if (coll.gameObject.tag == "Player")
//        {
//            if (coll.gameObject.GetComponent<Inventory>().holding)
//            {
//                timer += Time.deltaTime;
//                if (timer >= maxTimer)
//                {
//                    transform.parent.gameObject.GetComponent<NPCAlert>().alert = true;
//                    transform.parent.gameObject.GetComponent<NPCAlert>().lastLocation = coll.transform.position;
//                }
//            }
//        }
//
//
//    }
//    void OnTriggerExit2D(Collider2D coll)
//    {
//        if (coll.gameObject.tag == "Player")
//        {
//            print(timer);
//        }
//    }

}
