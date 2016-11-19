using UnityEngine;
using System.Collections;

public class ProjectileController : MonoBehaviour {

	//vector 2 speed to control y movement of the object
	Vector2 speed = new Vector2(0f, 0.5f);

	//transform object
	Transform _transform;

	//current position
	Vector2 _currentPosition;

	// Use this for initialization
	void Start () {
		_transform = gameObject.transform;
		_currentPosition = _transform.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		//adds y coordinate to current position
		_currentPosition += speed;
		//over writes object position with current position
		_transform.position = _currentPosition;
	}

	void Update(){
		
		//destroys current object if it goes off screen
		if (_transform.position.y > 4.8f)
			Destroy (gameObject);
	}
}
