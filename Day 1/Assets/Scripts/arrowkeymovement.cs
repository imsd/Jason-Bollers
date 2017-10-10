using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowkeymovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Makes the left and right arrow rotate object
        float rotationx = Input.GetAxis("Vertical");
        float rotationy = Input.GetAxis("Horizontal");
        //Calls for rotation
        Vector3 v3 = new Vector3(rotationx, rotationy, 0);
        //Rotate
        transform.Rotate(v3);

		
	}
}
