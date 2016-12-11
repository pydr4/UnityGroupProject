using UnityEngine;
using System.Collections;
/*
 * Title: Amazing Space Shooter
 * Group: #6
 * 
 * Members: 
 * <Makoto Wilson - 100810278>
 * <Jierong Fan   - 100986919>
 * 
 * Course: Game Development
 * 
 * Date: 12/11/2016
*/
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
