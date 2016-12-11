using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
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
public class GameOverController : MonoBehaviour {

	//score label for gameover
	[SerializeField]
	private Text scorelbl = null;

	//highscore label for gameover
	[SerializeField]
	private Text highScorelbl = null;

	// Use this for initialization
	void Start () {
		//sets the current score and highscore
		scorelbl.text = "Score: " + Player.Instance.Points;
		highScorelbl.text = "All Time Best: " + Player.Instance.HighScore;
	}

	public void OpenNewGame(){
		//click on the button to goback to first screen
		SceneManager.LoadScene (0);
	}

}
