using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTwoards : MonoBehaviour {
	public Transform target;
	public float speed = 7.5f;
	public Rigidbody rb;

	// Use this for initialization
	void Start () {
	rb = GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void Update () {
		float step = speed * Time.deltaTime;
	transform.position = Vector3.MoveTowards(transform.position, target.position, step);
	}
}
