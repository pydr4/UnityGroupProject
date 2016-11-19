using UnityEngine;
using System.Collections;

public class ProjectileController : MonoBehaviour {

	//speed of the bullet
	private float bulletSpeed = 15f;

	//transform object
	private Transform _transform;

	//RigidBody of gameobject
	private Rigidbody2D rigid;


	// Use this for initialization
	void Start () {
		_transform = this.gameObject.transform;
		rigid = this.gameObject.GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void FixedUpdate () {

		Vector3 movement = new Vector3 (0f, bulletSpeed, 0f);
		//movement = movement + _transform.forward;
		//rigid.velocity = movement;
		rigid.velocity = bulletSpeed * _transform.up;

	}

	void Update(){
		
		//destroys current object if it goes off screen
		if (_transform.position.y > 4.8f)
			Destroy (gameObject);
	}
}
