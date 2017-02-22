using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour {
    //public static void LoadScene;
   // public SceneManager sceneM;

    void OnGUI()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        //if (GUILayout.Button("Press Me"))
        //Debug.Log("Hello!");

        // Make a background box
        GUI.Box(new Rect(10, 10, 490, 360), "Loader Menu");

        // Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
        if (GUI.Button(new Rect(20, 40, 470, 155), "Start"))
        {
            //Application.LoadLevel(1);
            SceneManager.LoadScene(1, LoadSceneMode.Single);
            
            
        }

        // Make the second button.
        if (GUI.Button(new Rect(20, 205, 470, 155), "Exit"))
        {
            //Application.LoadLevel(2);
            Application.Quit();
        }
    }
     void Load(string sceneName)
    {

    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
