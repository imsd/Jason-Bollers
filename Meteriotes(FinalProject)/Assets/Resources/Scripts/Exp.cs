using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exp : MonoBehaviour {

	public GameObject effect; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter() { 
	Instantiate(effect,transform.position,transform.rotation); 
	Destroy(effect,3f); 
	Destroy(gameObject); 
	}
}
