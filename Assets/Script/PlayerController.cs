using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	//variable to store time
	private float time = 0f;
	//time delay constant to store delay in between shots
	private const float timeDelay = 0.2f;

	[SerializeField]
	private GameObject prefab = null;

	//speed of the player object
	private float speed = 10; 

	//minimum speed player can go
	private float angle = 0;

	//Max X and Y coordinate for Camera
	private Vector2 cameraPos = new Vector2(6.43f,4.7f);

	//player location
	private Transform _transform;

	//rigid body of the player
	private Rigidbody2D rigid;

	// Use this for initialization
	void Start () {
		rigid = GetComponent<Rigidbody2D> ();
		_transform = gameObject.transform;
	}
	
	// Update is called once per frame
	void FixedUpdate () {		
		//gets the vertical user input, up and down
		float moveY = Input.GetAxis ("Vertical");
		//gets the horizontal user input, left and right
		float moveX = Input.GetAxis ("Horizontal");

		//sets movement of the x and y axis from userinput
		Vector2 movement = new Vector2 (moveX * speed, moveY * speed);

		//limits the x movement
		if (moveX > 0
		    &&
		    _transform.position.x > cameraPos.x)
			movement = new Vector2 (0f, movement.y);
		else if (moveX < 0
		    &&
		    _transform.position.x < -cameraPos.x)
			movement = new Vector2 (0f, movement.y);

		//limits the y movement
		if (moveY > 0
		    &&
		    _transform.position.y > cameraPos.y)
			movement = new Vector2 (movement.x, 0f);
		else if (moveY < 0
		    &&
		    _transform.position.y < -cameraPos.y)
			movement = new Vector2 (movement.x, 0f);

		//sets the speed of the player object
		rigid.velocity = movement;
	}

	void Update(){
		//if fire is greater than 0, fire button is pressed
		float fire = Input.GetAxis("Fire1");


		if (Time.time >= time && fire > 0) 
		//checks if the fire button is pressed and player can shoot
		{
			//slows player while its shooting
			speed = 5f;
			Shoot ();

			//introduces delay till next shot
			time = Time.time + timeDelay;

		} else {
			speed = 10f;
		}
	
	}

	void Shoot()
	//instantiates 3 bullet prefab and instantiate its location to player position
	//3 bullets are angled 30, 0, -30 degree to shoot 3 ways
	{
		//creates position of the bullet object
		Vector2 pos = new Vector2 (_transform.position.x, _transform.position.y + 1f);
		//initial angle of bullet
		angle = 30f;
		for (int i = 0; i < 3; i++) {
			//creates 3 bullet object each angles shift by -30 degree from 30 degree
			Instantiate (prefab, pos, Quaternion.Euler(0,0,angle));
			angle -= 30f;
		}
	
	}
}
