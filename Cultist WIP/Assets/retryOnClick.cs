using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class retryOnClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void retry()
    {

        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    public void exit()
    {
        Application.Quit();
    }
}
