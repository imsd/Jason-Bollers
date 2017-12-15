using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {


	void start(){

	}

	void OnTriggerEnter(Collider other) {
	Destroy(other.gameObject);

	}

}
