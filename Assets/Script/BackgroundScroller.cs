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

//Controls background scrolling
public class BackgroundScroller : MonoBehaviour {
	//controls scroll speed
	[SerializeField]
	public float scrollSpeed = 0.5f;

	//renderer to offset the background
	private Renderer rend;

	void Start () {
		rend = (Renderer) gameObject.GetComponent<Renderer> ();
	
	}
	

	void Update () {
		//shifts background to make it look like its moving
		Vector2 offset = new Vector2 (0, Time.time * scrollSpeed);
		rend.material.mainTextureOffset = offset;
	}
}
