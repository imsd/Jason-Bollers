using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour {
    public GameObject go;
    //added float to create access to inspector
    public float StartAfter = 1f;
    public float SpawnFrequency = 1f;
    public float xStartRange = -5;
    public float xEndRange = 5;
    public float zStartRange = -5;
    public float zEndRange = 5;
    public float yStartRange;
    public float yEndRange;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space"))
        {
            transform.position = (new Vector3(Random.Range(xStartRange, xEndRange), Random.Range(yStartRange, yEndRange), Random.Range(zStartRange, zEndRange)));
            Instantiate(go, transform.position, Quaternion.identity);
        }
		
	}
    //Get called when mouse hovers over an object
    void OnMouseOver()
    {
        transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime);
        
    }
    /*void OnMouseDown()
    {

        transform.Rotate(new Vector3(0, 360, 0) * Time.deltaTime);
    }*/
}
