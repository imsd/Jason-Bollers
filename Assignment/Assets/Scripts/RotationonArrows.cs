using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationonArrows : MonoBehaviour {
    public KeyCode leftkey;
    public KeyCode rightkey;
    public float speed = 60;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(rightkey))
        {
            transform.Rotate(Vector3.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(leftkey))
        {
            transform.Rotate(-Vector3.up * speed * Time.deltaTime);
        }


    }
}
