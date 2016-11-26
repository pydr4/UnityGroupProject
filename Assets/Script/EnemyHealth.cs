using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {
	[SerializeField]
	GameObject explosion = null;

	[SerializeField]
	private int health = 20;

	public int Health {
		get {
			return health;
		}set{ 
			this.health = value;
		}
	}
		
	void FixedUpdate () {
		if (health <= 0) {
			Transform expl = explosion.transform;
			expl.position = gameObject.transform.position;
			Instantiate (explosion);
			Destroy (this.gameObject);
		}
	}
}
