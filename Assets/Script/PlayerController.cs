using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
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
		float fire = Input.GetAxis("Fire1");

		if (fire > 0) {
			Vector2 pos = new Vector2 (_transform.position.x - 2f, _transform.position.y + 1f);
			angle = 30f;
			for (int i = 0; i < 3; i++) {
				pos.x += 1f;

				Instantiate (prefab, pos, Quaternion.Euler(0,0,angle));
				angle -= 30f;
			}


		} else {
			speed = 10f;
		}
	
	}
}
