using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{

    // add a gameobject to the inspector
    // that we can access in this script
    public GameObject go;
    public Vector3 spawnvalues;
    public float spawnwait;
    public float spawnmostwait;
    public float spawnleastwait;
    public int startwait;
    public bool stop;
    int rand;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(spawner());
    }

    // Update is called once per frame
    void Update()
    {
        spawnwait = Random.Range(spawnleastwait, spawnmostwait);
    }
    IEnumerator spawner()
    {
        yield return new WaitForSeconds(startwait);
        while(!stop)
        {
            rand = Random.Range(0,2);
            Vector3 spawnposition = new Vector3 (Random.Range(-spawnvalues.x, spawnvalues.x), 1, Random.Range(-spawnvalues.z, spawnvalues.z));
            Instantiate(go, spawnposition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
            yield return new WaitForSeconds(spawnwait);
        }
    }
}