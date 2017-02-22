using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class countDown : MonoBehaviour
{
    public float timeLeft = 300.0f;

    Text text;


    void Awake()
    {
       text =  GetComponent<Text>();
        
    }
    void Update()
    {
        timeLeft -= Time.deltaTime;
        text.text = "" + Mathf.Round(timeLeft);
        if (timeLeft < 0)
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
    }
}