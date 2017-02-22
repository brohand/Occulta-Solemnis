using UnityEngine;
using System.Collections;

public class Flicker : MonoBehaviour {

    Light lamp;

    public float minIntensity = 0.25f;
    public float maxIntensity = 0.5f;

    float random;
    float intense;

    void Start()
    {
        lamp = GetComponent<Light>();
        //random = Random.Range(0.0f, 65535.0f);
        
        //intense = 0;
    }

    void Update()
    {

        random = Random.Range(0, 30);

        if (random < 1)
        {
            //intense = 0.0f;
            lamp.intensity = 1.0f;
        } else if (random > 5)
        {
            //intense = 65535.0f;
            lamp.intensity = 6.98f;
        }

        //float noise = Mathf.PerlinNoise(intense, Time.time);
        //lamp.intensity = Mathf.Lerp(minIntensity, maxIntensity, noise);
        //GetComponent<Light>().intensity = Mathf.Lerp(minIntensity, maxIntensity, noise);
    }
}
