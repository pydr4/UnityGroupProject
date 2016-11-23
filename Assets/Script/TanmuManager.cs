using UnityEngine;
using System.Collections;

public class TanmuManager : MonoBehaviour {

	public GameObject tanmu;               // the enemy prefab to be spawned
	public float spawnTime = 0.01f;            // a time for spawn.
	public Transform spawnPoints;         // an array of the spawn points 



	// Use this for initialization
	void Start () {
		//calling the chaos(enemy) fleet
		InvokeRepeating ("Tanmu", spawnTime, spawnTime);
	}

	//spawn enemy
	void Tanmu () {
		float rotaz = 0;
		//summon the enmey
		Instantiate (tanmu, spawnPoints.position, spawnPoints.rotation);
		spawnPoints.transform.Rotate (0, 0, rotaz);
		rotaz++;
	}
}
