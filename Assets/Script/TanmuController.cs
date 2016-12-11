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
