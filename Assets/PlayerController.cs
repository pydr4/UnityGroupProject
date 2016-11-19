using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	//speed of the object, can also be set through unity property
	[SerializeField]
	private float speed = 0; 

	//Max X and Y coordinate for Camera
	private Vector2 cameraPos = new Vector2(6.43f,4.7f);

	//player location
	private Transform _transform;
	//
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
}
