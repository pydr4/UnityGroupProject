using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour {
	
	public GameObject enemy;               // the enemy prefab to be spawned
	public float spawnTime = 3f;            // a time for spawn.
	public Transform[] spawnPoints;         // an array of the spawn points 






	// Use this for initialization
	void Start () {
		//calling the chaos(enemy) fleet
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}
	
	//spawn enemy
	void Spawn () {
		//spawn enemy on random posistion 
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);
		//summon the enmey
		Instantiate (enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
	}
}
