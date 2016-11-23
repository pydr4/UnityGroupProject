using UnityEngine;
using System.Collections;

public class EnemySSController : MonoBehaviour {

	[SerializeField]
	private float speed = 0.2f;

	private Transform _transform;

	private	Vector2 _currentPos;

	private int timing = 0; 
	// Use this for initialization
	void Start () {
		_transform = gameObject.transform;
		_currentPos = _transform.position;

	}
		
	// Update is called once per frame
	void FixedUpdate () {
		_currentPos = _transform.position;
		_currentPos -= new Vector2(0,speed);
		_transform.position = _currentPos;

		if (timing < 100) {
			if (_transform.position.y < 1f) {
				_currentPos.y= 1f;
				_transform.position = _currentPos;
			}
			timing++;
		}else{
			
		}

	}

	void Tanmu(){
		
	}

}
