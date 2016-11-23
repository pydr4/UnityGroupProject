using UnityEngine;
using System.Collections;

public class TanmuController : MonoBehaviour {
	Rigidbody2D rgbd2d;
	// Use this for initialization
	void Start () {
		rgbd2d = gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		rgbd2d.velocity = rgbd2d.transform.forward * 6;

	}

}
