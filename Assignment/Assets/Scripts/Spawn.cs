using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
	//added public to acces from inspector
	public GameObject go;
	//added float to create access to inspector
	public float StartAfter=1f;
	public float SpawnFrequency = 1f;
    
	//public Vector3 myRotation;

	public Transform shootfrom;

	// Use this for initialization
	void Start () {
		//Do somethign every x seconds
		//1:What you want to repeat
		//2:How many second
		//3:Repeat every x seconds
		InvokeRepeating ("SpawnThing", StartAfter, SpawnFrequency);
	}
	
	// Update is called once per frame
	void SpawnThing() {
		//move the spawner
		//transform.position = (new Vector3 (Random.Range(xStartRange,xEndRange), Random.Range(yStartRange,yEndRange), Random.Range(zStartRange,zEndRange)));

		//To create a object use Instantiate function
		//Requires 3 arguments
		//1:The object
		//2:The placement
		//3:Rotation
		
			GameObject cannonball = Instantiate (go, shootfrom.position, Quaternion.identity);
			cannonball.GetComponent<Rigidbody> ().AddForce (Vector3.forward * 3000);

		
	}


}
