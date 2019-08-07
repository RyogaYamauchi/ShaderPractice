using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spotLight_ran : MonoBehaviour {
    public GameObject lightObj;
    public float span = 0.5f;
    private float currentTime = 0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        currentTime += Time.deltaTime;

        if (currentTime > span)
        {
            float temp = Random.Range(0f,2f);
            //Debug.Log(temp);
            if (temp <= 1.5) lightObj.GetComponent<Light>().intensity = 0;

            currentTime = 0f;
        }
        else{
            lightObj.GetComponent<Light>().intensity = 1;
        }

	}
}
