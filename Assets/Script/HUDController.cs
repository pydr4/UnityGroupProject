using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUDController : MonoBehaviour {
	[SerializeField]
	Text pointslabel = null;

	[SerializeField]
	Text lifeLabel = null;


	// Use this for initialization
	void Start () {
		Player.Instance.hud = this;
		NewGame ();
	}

	public void NewGame(){
		Player.Instance.Points = 0;
		Player.Instance.Life = 3;
		pointslabel.text = "Score: " + Player.Instance.Points;
		lifeLabel.text = "lives: " + Player.Instance.Life;
	}

	public void UpdateLife(){
		lifeLabel.text = "lives: " + Player.Instance.Life;
	}

	public void UpdatePoints(){
		pointslabel.text = "Score: " + Player.Instance.Points;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
