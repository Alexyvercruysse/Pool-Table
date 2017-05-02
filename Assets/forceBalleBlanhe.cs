using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forceBalleBlanhe : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject ball0 = GameObject.Find ("Ball0");
		Rigidbody rigid = ball0.GetComponent<Rigidbody> ();
		rigid.AddForce (new Vector3 (750,0,0));

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
