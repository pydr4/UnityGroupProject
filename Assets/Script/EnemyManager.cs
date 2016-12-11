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
public class EnemyManager : MonoBehaviour {
	
	public GameObject enemy;               // the enemy prefab to be spawned
	public float spawnTime = 3f;            // a time for spawn.
	public Transform[] spawnPoints;         // an array of the spawn points 

	public float bossTime = 30;





	// Use this for initialization
	void Start () {
		//calling the chaos(enemy) fleet
		bossTime = bossTime + Time.time;
			InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}
	
	//spawn enemy
	void Spawn () {
		//spawn enemy on random posistion 
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);
		//summon the enmey
		if (Time.time >= bossTime) {

		} else {
			Instantiate (enemy, spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);
		}
	}
}
