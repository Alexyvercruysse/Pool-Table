using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyBallOnContact : MonoBehaviour {


	// Use this for initialization
	int score;
	void Start () {
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider col){
		Destroy (col.gameObject);
		score++;
	}
	void OnGUI(){
		GUI.Box(new Rect(10, 10, 200, 20), "Score : "+score);
	}


}
