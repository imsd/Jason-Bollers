using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour {
	public Renderer rend;
	public GameObject go;
	public Vector3 myRotation;

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
		transform.localScale += new Vector3 (.01f, .01f, .01f);
		transform.Rotate (myRotation * Time.deltaTime);
		for (int i = 3; i < 13; i++) {
			Vector3 myvec = new Vector3 (0, i, 0);
			Instantiate (go,myvec,Quaternion.identity);

}

			
}
}
