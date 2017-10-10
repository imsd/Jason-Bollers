using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnHover : MonoBehaviour {
	public Vector3 myRotation;
	public GameObject go;
	public Renderer rend;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseEnter(){
		rend.material.color = Color.red;
	}
	void OnMouseExit(){
		rend.material.color = Color.white;
	}
	void OnMouseOver(){
		transform.Rotate (myRotation * Time.deltaTime);
		for (int i = 10; i < 1; i++) {
			Vector3 myvec = new Vector3 (i, 0, 0);
			Instantiate (go,myvec,Quaternion.identity);

		}
	}
}
