using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	// nameing Vector3 to myRotation
	public Vector3 myRotation;
	// Use this for initialization
	//Runs only once
	void Start () {
		
	}
	
	// Update is called once per frame
	//Continues to run
	void Update () {
		transform.Rotate (myRotation * Time.deltaTime);
	}
}
