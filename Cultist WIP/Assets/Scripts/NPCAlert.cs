using UnityEngine;
using System.Collections;

public class NPCAlert : MonoBehaviour
{
    public bool alert;
    public Vector2 lastLocation;
    // Use this for initialization
    void Start()
    {
        alert = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (alert)
        {
            alertDetective(lastLocation);
            alert = false;
        }
    }

    void alertDetective(Vector2 lastLocation)
    {
        GameObject.FindGameObjectWithTag("Detective").GetComponent<DetectiveClass>().myLastLocation = lastLocation;
        //print("ALERTED");
    }
}