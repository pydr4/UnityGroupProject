using UnityEngine;
using System.Collections;

public class EnemySSController : MonoBehaviour {

	[SerializeField]
	private float speed = 0.2f;

	[SerializeField]
	private GameObject tanmu;

	private Transform _transform;

	private float rotai = 0f;

	private Transform tanmuSpawn;

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
				Tanmu ();
			}

			timing++;
		}else{
			
		}

	}

	void Tanmu(){
		tanmuSpawn = gameObject.transform;
		float rad = 0;

		for (int i = 0; i < 4; i++) {
			GameObject _tanmu = (GameObject)Instantiate (tanmu, tanmuSpawn.position, Quaternion.Euler (0, 0, rotai+rad));

			_tanmu.GetComponent<Rigidbody2D> ().velocity = _tanmu.transform.up * -5f;

			Destroy (_tanmu, 3.0f);

			rad += 90f;
		}rotai += 25f;
	}

}
