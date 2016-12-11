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
public class BossController : MonoBehaviour {
	//controlls speed of boss movement
	[SerializeField]
	private float speed = 10f;

	//handles boss's current position and movement;
	private Transform _transform;

	//checks if boss is going left or right
	private bool goLeft = true;
	private bool goRight = false;

	//rigid body for boss
	private Rigidbody2D rig2d;

	//rate boss fires bullet
	private float fireRate = 0.5f;
	//variable to detect if its time to fire
	private float nextFire = 0;
	//rate which boss changes skills
	private float changeRate = 5f;
	//checks if its time to change skill
	private float nextSkill = 0;
	//name of the skill;
	private string skillName = "Slice";

	//sets projectile prefabs
	public GameObject tama1 = null;
	public GameObject tama2 = null;
	public GameObject tama3 =null;

	//the rotation angle and limits
	private float rad =0;
	private float rotai =0;

	// Use this for initialization
	void Start () {
		rig2d = gameObject.GetComponent<Rigidbody2D> ();

	}

	// Update is called once per frame
	void FixedUpdate ()
	{

		if (gameObject.transform.position.x <= -5f) {
			goLeft = false;
			goRight = true;

		}else if (gameObject.transform.position.x >= 5f) {
			goLeft = true;
			goRight = false;
		}

		if (goLeft) {
			rig2d.velocity = new Vector2 (-speed, rig2d.velocity.y);
		} else if(goRight) {
			rig2d.velocity = new Vector2 (speed, rig2d.velocity.y);
		}
			
		if (Time.time > nextSkill) {
			//checks if its time to change skill or not
			nextSkill = changeRate + Time.time; // adds 5 seconds to current time;
			NewSkill (); //chooses new skill
		}
		if (Time.time > nextFire) {
			//checks if the currenttime is more than time to fire..
			//shoots and sets next fire time;
			nextFire = Time.time + fireRate;

			//shoots
			Invoke (skillName,0);
		}


	}

	void NewSkill(){
		//chooses random skill
		int index = Random.Range (0, 3);

		switch (index) {
		case 0:
			skillName = "PopBoom";
			break;
		case 1: 
			skillName = "Slice";
			break;
		case 2:
			skillName = "Trace";
			break;
		}
	}

	void PopBoom(){
		for (int j = 0; j < 5; j++) {
			for (int i = 0; i < 4; i++) {
				GameObject _tanmu = (GameObject)Instantiate (tama1, new Vector2 (-3f, 0f), Quaternion.Euler (0, 0, rotai + rad));
				GameObject _tanmu2 = (GameObject)Instantiate (tama1, new Vector2 (3f, 0f), Quaternion.Euler (0, 0, rotai - rad));
				_tanmu.GetComponent<Rigidbody2D> ().velocity = _tanmu.transform.up * -3f;
				_tanmu2.GetComponent<Rigidbody2D> ().velocity = _tanmu2.transform.up * -3f;
				Destroy (_tanmu, 1.5f);
				Destroy (_tanmu2, 1.5f);

				rad += 90f;
			}
			rotai += 30f;
	
		}
	}

	void Slice(){
		for (int j = 0; j < 2; j++) {
			for (int i = 0; i < 2; i++) {
				Vector2 left = new Vector3 (-0.5f, 0.5f,0) + gameObject.transform.position;
				Vector2 right = new Vector3 (0.5f, 0.5f,0) + gameObject.transform.position;
				GameObject _tanmu = (GameObject)Instantiate (tama1,right, Quaternion.Euler (0, 0, rotai + rad));
				GameObject _tanmu2 = (GameObject)Instantiate (tama1, left, Quaternion.Euler (0, 0, rotai - rad));
				_tanmu.GetComponent<Rigidbody2D> ().velocity = _tanmu.transform.up * -3f;
				_tanmu2.GetComponent<Rigidbody2D> ().velocity = _tanmu2.transform.up * -3f;
				Destroy (_tanmu, 3f);
				Destroy (_tanmu2, 3f);
				rad += 5f;
			}
			rotai += 10f;

		}
		rad = 0;
		rotai = 0;
		
	}


	void Trace(){
			for (int i = 0; i < 5; i++) {
				Vector2 left = new Vector3 (-0.5f, 0.5f,0) + gameObject.transform.position;
				Vector2 right = new Vector3 (0.5f, 0.5f,0) + gameObject.transform.position;
				GameObject _tanmu = (GameObject)Instantiate (tama2,right, Quaternion.Euler (0, 0, rotai + rad));
				GameObject _tanmu2 = (GameObject)Instantiate (tama2, left, Quaternion.Euler (0, 0, rotai + rad));
				_tanmu.GetComponent<Rigidbody2D> ().velocity = _tanmu.transform.up * -3f;
				_tanmu2.GetComponent<Rigidbody2D> ().velocity = _tanmu2.transform.up * -3f;
				Destroy (_tanmu, 2f);
				Destroy (_tanmu2, 2f);
				rad += 45f;
			}
			
		rad = 0;
		rotai = 0;
		}



}



