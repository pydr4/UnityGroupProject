using UnityEngine;
using System.Collections;
using UnityEngine.UI;
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
public class HUDController : MonoBehaviour {

	//textarea for points
	[SerializeField]
	Text pointslabel = null;

	//textarea for life
	[SerializeField]
	Text lifeLabel = null;


	// Use this for initialization
	void Start () {
		//sets player's hud
		Player.Instance.hud = this;
		//start fresh game
		NewGame ();
	}

	public void NewGame(){
		//sets player points and health
		Player.Instance.Points = 0;
		Player.Instance.Life = 5;

		//initialize texts
		pointslabel.text = "Score: " + Player.Instance.Points;
		lifeLabel.text = "lives: " + Player.Instance.Life;
	}

	public void UpdateLife(){
		//updates life text
		lifeLabel.text = "lives: " + Player.Instance.Life;
	}

	public void UpdatePoints(){
		//updates points text
		pointslabel.text = "Score: " + Player.Instance.Points;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
