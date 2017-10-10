using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletExpire : MonoBehaviour {
    public float expiretime = 0f;

	// Use this for initialization
	void Start () {
        Destroy(gameObject, expiretime);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
