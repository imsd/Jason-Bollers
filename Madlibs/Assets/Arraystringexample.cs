using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arraystringexample : MonoBehaviour {
	public string[] names;
	public string[] places;
	public string[] weapon;
	public string[] enemy;
	public string[] vehicle;
	public string[] chest;
	public string[] glimmer;
	public string[] subclass;
	public string[] boss;
	public string[] outcome;

	// Use this for initialization
	void Start () {
	//Loop through all array
//	for (int i = 0; i < names.Length; i++) {
//		Debug.Log (names [i]);
//		}
	//Random name in array
//	int rando = Random.Range(0, names.Length);
//	Debug.Log (names[rando]);

	//Makes a sentence out of a random name in the array
	int randoname = Random.Range(0, names.Length);
	int randoplace = Random.Range(0, places.Length);
	int randoweapon = Random.Range(0, weapon.Length);
	int randoenemy = Random.Range(0, enemy.Length);
	int randovehicle = Random.Range(0, vehicle.Length);
	int randochest = Random.Range(0, chest.Length);
	int randoglimmer = Random.Range(0, glimmer.Length);
	int randosubclass = Random.Range(0, subclass.Length);
	int randoboss = Random.Range(0, boss.Length);
	int randooutcome = Random.Range(0, outcome.Length);
	string line1 = "One day, " + names[randoname] + " went to " + places[randoplace] 
		+ " and picked up a " + weapon[randoweapon] + ", then a " + enemy[randoenemy] 
		+ " appeared and shots where fired. When the smoke cleared, the guardian spawned a "
		+ vehicle[randovehicle] + " and went a great distance. The guardian approaches a " 
		+ chest[randochest] + " and aquired " + glimmer[randoglimmer] + ". Then " + boss[randoboss] 
		+ " comes arround to bring great terror. The guardian takes arms and ready thier " 
		+ subclass[randosubclass] + " subclass and the story ends with a " + outcome[randooutcome] + ".";
	Debug.Log(line1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
