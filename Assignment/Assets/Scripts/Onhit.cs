using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onhit : MonoBehaviour {
    //   Animator animator;


	// Use this for initialization
	void Start () {
    //    animator = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag != "DontDestroy")
        {
            Destroy(col.gameObject);
        }

    }
    //    void OnTriggerEnter(Collider other)
    //{
    //    Destroy(this.gameObject);
    //}
}
