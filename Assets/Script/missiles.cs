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
public class missiles : MonoBehaviour {
	/**First try
	 * 
	 * private const float max_rota = 90;

	private float max_rota_fra;


	public GameObject target;
	// Use this for initialization
	void Start () {
		  max_rota_fra = max_rota / ((float)(Application.targetFrameRate == -1 ? 60 : Application.targetFrameRate));
	}
	
	// Update is called once per frame
	void Update () {
		float dx = target.transform.position.x - this.transform.position.x;
	    float dy = target.transform.position.y - this.transform.position.y;
		float rotationZ = Mathf.Atan2(dy, dx) * 360 / Mathf.PI;
	         	 rotationZ -= 90;
		         rotationZ = MakeSureRightRotation(rotationZ);

		         float originRotationZ = MakeSureRightRotation(this.transform.eulerAngles.z);
		         float addRotationZ = rotationZ - originRotationZ;
		        //
			         {
			             addRotationZ -= 360;
			         }
		        //
		addRotationZ = Mathf.Max(-max_rota_fra, Mathf.Min(max_rota_fra, addRotationZ));

		         this.transform.eulerAngles = new Vector3(0, 0, this.transform.eulerAngles.z + addRotationZ);

		        this.transform.Translate(new Vector3(0, 5.0f * Time.deltaTime, 0));
	}

	private float MakeSureRightRotation(float rotation){
		rotation += 360;
		rotation %= 360;
		return rotation;
	}**/

	/**
		Second try
	**/
	public float speed = 10f;
	public float rotatingSpeed = 200;
	public GameObject player = null;
	Vector3 lastMove;
	Rigidbody2D ri2d;

	void Start (){
		player = GameObject.FindGameObjectWithTag("Player");
		ri2d = GetComponent<Rigidbody2D> ();
		lastMove = player.transform.position;
	}


	void FixedUpdate(){
		Vector3 pointToTarget = (Vector3)transform.position - (Vector3)lastMove;
		pointToTarget.Normalize ();

		float z = Vector3.Cross (pointToTarget, transform.right).z;

		ri2d.angularVelocity = rotatingSpeed * z;
		ri2d.velocity = transform.right * speed;
	}


}
