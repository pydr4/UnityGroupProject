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
public class EnemySSController : MonoBehaviour {

	[SerializeField]
	private float speed = 0.2f;

	[SerializeField]
	private GameObject tanmu=null;

	private Transform _transform;

	private float rotai = 0f;

	private Transform tanmuSpawn;

	private	Vector2 _currentPos;

	private int timing = 0;

	private int shoot = 0;
	// Use this for initialization
	void Start () {
		_transform = gameObject.transform;
		_currentPos = _transform.position;
		InvokeRepeating("Tanmu",0.5f, 0.1f);
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
		}
		if (_transform.position.y < -5.5f) {
			Destroy (gameObject);
		}


	}

	void Tanmu(){
		tanmuSpawn = gameObject.transform;
		float rad = 0;
		shoot++;
		if(shoot < 10){
		for (int i = 0; i < 4; i++) {
			GameObject _tanmu = (GameObject)Instantiate (tanmu, tanmuSpawn.position, Quaternion.Euler (0, 0, rotai+rad));

			_tanmu.GetComponent<Rigidbody2D> ().velocity = _tanmu.transform.up * -5f;

			Destroy (_tanmu, 3.0f);

			rad += 90f;
		}rotai += 25f;
		}
	}

}
