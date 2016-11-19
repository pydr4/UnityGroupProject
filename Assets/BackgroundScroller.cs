using UnityEngine;
using System.Collections;

public class BackgroundScroller : MonoBehaviour {
	[SerializeField]
	public float scrollSpeed = 0.5f;

	private Renderer rend;
	void Start () {
		rend = (Renderer) gameObject.GetComponent<Renderer> ();
	
	}
	

	void Update () {
		Vector2 offset = new Vector2 (0, Time.time * scrollSpeed);
		rend.material.mainTextureOffset = offset;
	}
}
