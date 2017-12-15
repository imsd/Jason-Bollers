using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteors : MonoBehaviour {
	public GameObject Meteor;


	public float spawntime = 10f;
	public float radius = 10f;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", spawntime, spawntime);
	}
	
	// Update is called once per frame
	void Update () {
	Instantiate (Meteor, Random.insideUnitSphere * radius + transform.position, Random.rotation);

	}

}
