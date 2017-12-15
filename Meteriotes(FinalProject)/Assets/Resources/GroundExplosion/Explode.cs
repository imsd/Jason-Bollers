using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour {
	public float delay = 3f;
	public GameObject explosion;
	float countdown;
	bool hasExploded = false;

	// Use this for initialization
	void Start () {
		countdown = delay;
		
	}
	void Update (){
//		countdown -= Time.deltaTime;
//		if (countdown <= 0f && !hasExploded) {
		hasExploded = true;
//		}
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider col){
	Instantiate(explosion, transform.position, transform.rotation);
	Destroy(gameObject);	
	}
}
