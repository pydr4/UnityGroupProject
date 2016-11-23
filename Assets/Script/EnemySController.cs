using UnityEngine;
using System.Collections;

public class EnemySController : MonoBehaviour {
	[SerializeField]
	private float speed = 0.2f;

	[SerializeField]
	private GameObject tanmu;
	[SerializeField]
	private GameObject player;

	private float rotai = 0f;

	private Transform tanmuSpawn;

	private Transform _transform;

	private	Vector2 _currentPos;

	// Use this for initialization
	void Start () {
		_transform = gameObject.transform;
		_currentPos = _transform.position;
		InvokeRepeating ("Fire", 0.01f, 0.01f);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		_currentPos = _transform.position;
		_currentPos -= new Vector2(0,speed);
		_transform.position = _currentPos;

		if (_transform.position.y < -5.5f) {
			Destroy (gameObject);
		}


	}

	void Fire(){
		tanmuSpawn = gameObject.transform;


		GameObject _tanmu = (GameObject)Instantiate (tanmu, tanmuSpawn.position, Quaternion.Euler (0, 0, rotai));


		_tanmu.GetComponent<Rigidbody2D> ().velocity = _tanmu.transform.up * -5f;

		Destroy (_tanmu, 3.0f);
		
		rotai+= 10f;
	}
}
