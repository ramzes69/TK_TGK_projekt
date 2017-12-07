using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freezer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    public void setTimeScale(float timeScale)
    {
        Time.timeScale = timeScale;
    }
}
