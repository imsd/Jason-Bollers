using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour
{
    
    public GameObject go;
    public float shootrate = 0f;
    public float shootforce = 0f;
    public float moveforce = 0f;
    private float shootRateTimeStamp = 0f;
    private Rigidbody rbody;

    //public Vector3 myRotation;

    public Transform shootfrom;

    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal") * moveforce;
        float v = Input.GetAxisRaw("Vertical") * moveforce;

        rbody.velocity = new Vector3(h, v, 0);
        if (Input.GetKey(KeyCode.Space))
        {
            if (Time.time > shootRateTimeStamp)
            {
                GameObject cannonball = Instantiate(go, shootfrom.position, shootfrom.rotation);
                cannonball.GetComponent<Rigidbody>().AddForce(shootfrom.forward * shootforce);
                shootRateTimeStamp = Time.time + shootrate;
            }
        }



    }


}
