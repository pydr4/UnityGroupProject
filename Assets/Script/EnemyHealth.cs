using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
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
public class EnemyHealth : MonoBehaviour {

	//explosion will be played when enemy dies
	[SerializeField]
	GameObject explosion = null;

	// points that current enemy give on death
	private int points = 0;

	//enemy health
	[SerializeField]
	private int health = 20;

	//getter and setter for health
	public int Health {
		get {
			return health;
		}set{ 
			this.health = value;
		}
	}
		

	void Start(){
		//sets point (10 times the health)
		points = health * 10;
	}

	void FixedUpdate () {
		//sets point and animation on enemy death and removes game object
		if (health <= 0) {
			Player.Instance.Points += points;
			Transform expl = explosion.transform;
			expl.position = gameObject.transform.position;
			Instantiate (explosion);

			//if enemy tag is boss.. load winning scene
			if (this.gameObject.tag == "boss")
				SceneManager.LoadScene ("win");
			
			Destroy (this.gameObject);
		}
	}
}
