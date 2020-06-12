using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonManager : MonoBehaviour {
    public int score = 0;

	// Use this for initialization
	private void OnMouseDown () {
        Debug.Log("Click Hocche");
        score++;
	}
	
	
	void Update () {
		
	}
}
