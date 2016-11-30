using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {
	[SerializeField]
	GameObject explosion = null;

	private int points = 0;

	[SerializeField]
	private int health = 20;

	public int Health {
		get {
			return health;
		}set{ 
			this.health = value;
		}
	}
		

	void Start(){
		points = health * 10;
	}

	void FixedUpdate () {
		if (health <= 0) {
			Player.Instance.Points += points;
			Transform expl = explosion.transform;
			expl.position = gameObject.transform.position;
			Instantiate (explosion);
			Destroy (this.gameObject);
		}
	}
}
