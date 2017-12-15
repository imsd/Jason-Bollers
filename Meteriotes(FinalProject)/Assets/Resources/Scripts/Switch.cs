using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {
	public Camera camera1;
	public Camera camera2;

	// Use this for initialization
	void Start () {
		camera1.enabled = true;
		camera2.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown(){
		camera1.enabled = !camera1.enabled;
		camera2.enabled = !camera2.enabled;

		}

	}

