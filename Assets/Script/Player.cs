using UnityEngine;
using System.Collections;
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
public class Player {

	//highscore
	private const string key = "HIGH_SCORE";

	//creates player sigleton
	private Player(){
		//if highscore exists
		//gets  highscore
		if (PlayerPrefs.HasKey (key)) {
			_highScore = PlayerPrefs.GetInt (key);
		}
	}


	private static Player _instance = null;

	//required for singleton
	public static Player Instance{

		get{ 
			if (_instance == null) {
				_instance = new Player ();
			}
			return _instance;
		}
	}

	//for displaying points and health
	public HUDController hud = null;

	//default points;
	private int _points = 0;
	private int _highScore = 0; //default highscore
	private int _life = 5; //default health

	//getter and setter for points;
	public int Points {
		get {
			return _points;
		}set{ 
			_points = value;
			//sets current highscore
			HighScore = _points;
			//updates hud display
			hud.UpdatePoints ();
		}
	}
 	
	//life getter and setters
	public int Life {
		get {
			return _life;
		}set{
			_life = value;
			//updates life display
			hud.UpdateLife ();

			//if life is 0, loads gameover scene
			if (_life <= 0) {
				SceneManager.LoadScene ("gameOver");
			}
		}
	}

	public int HighScore {
		get {
			return _highScore;
		}set{ 
			if (value > _highScore) {
				//if value is greater than highscore, sets the highscore
				_highScore = value;
				PlayerPrefs.SetInt (key, _highScore);
			}
		}
	}
}
