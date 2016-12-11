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
public class BossManager : MonoBehaviour {

	private AudioSource sound;				// sound before boss spawns
	public GameObject enemy;               // the enemy prefab to be spawned        
	public Transform spawnPoints;         // an array of the spawn points 
	public GameObject bgm;
	public float bossTime = 30;

	private AudioSource currentBGM; // sets boss bgm




	// Use this for initialization
	void Start () {
		//setup soundsource
		sound = this.gameObject.GetComponent<AudioSource> (); 
		currentBGM = bgm.GetComponent<AudioSource> ();

		//calling the chaos(enemy) fleet
		Invoke("PlaySound",bossTime);
		Invoke("Spawn",bossTime+5f);
	}

	//spawn enemy
	void Spawn () {
		//summon the enmey
		if (Time.time >= bossTime) {
			Instantiate (enemy, spawnPoints.position, spawnPoints.rotation);

		} else {
			
		}
	}

	void PlaySound(){
		 //plays boss spawn sound
		if (currentBGM.isPlaying)
			currentBGM.Stop ();
		
		if (sound != null)
			sound.Play ();
	}
}
