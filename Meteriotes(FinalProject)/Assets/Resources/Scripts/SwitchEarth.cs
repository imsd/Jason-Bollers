using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchEarth : MonoBehaviour {
	public Camera camera1;
	public Camera camera2;

	// Use this for initialization
	void Start () {
	camera1.enabled = false;
	camera2.enabled = true;
	}

	// Update is called once per frame
	void Update () {

	}
	void OnMouseDown(){
	camera1.enabled = !camera1.enabled;
	camera2.enabled = !camera2.enabled;

	}

}

