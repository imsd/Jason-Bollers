using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iteration : MonoBehaviour {

	public GameObject go;
	// Use this for initialization
	void Start () {
		for (int i = 3; i < 13; i++) {
			Vector3 myvec = new Vector3 (0, i, 0);
			Instantiate (go,myvec,Quaternion.identity);
			
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
