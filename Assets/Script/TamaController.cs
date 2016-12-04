using UnityEngine;
using System.Collections;

public class TamaController : MonoBehaviour {

	Rigidbody2D rgbd2d;
	//private float angle =30f;
	//private int count=0; 
	//private bool goForward = false;
	//Vector3 endPos=new Vector3(); 
	float angle = 0;

	[SerializeField]
	GameObject player = null;
	// Use this for initialization
	/**void Start () {
		_transform = this.gameObject.transform;
		rgbd2d = gameObject.GetComponent<Rigidbody2D> ();
		goForward = false;
		endPos = new Vector3 (_transform.position.x + 0.5f, _transform.position.y + 0.5f,0);
	}

	// Update is called once per frame
	void Update () {
		//Transform tran = player.transform;
		//rgbd2d.transform.Rotate (0,angle+=angle,0);
		//rgbd2d.MoveRotation (Quaternion.RotateTowards(transform.position,tran.position,180f));
		if(_transform.position.y > endPos.y && _transform.position.x > endPos.x){
			goForward = true;
		}
		if (goForward) {
			rgbd2d.velocity = 6f * _transform.up;
		} else {
			rgbd2d.velocity = -6f * _transform.up;
		}
	}
*/
	void Start(){
		rgbd2d = gameObject.GetComponent<Rigidbody2D> ();
		InvokeRepeating ("Rotation", 0.5f, 0.1f);
	}
	void FixedUpdate() {
		


	}

	void Rotation(){
		transform.rotation = Quaternion.Euler (0, 0, angle += 50f);
		rgbd2d.velocity = gameObject.transform.up * 5f; 
	}

}
