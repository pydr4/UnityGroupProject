using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player {

	private const string key = "HIGH_SCORE";

	//creates player sigleton
	private Player(){
		if (PlayerPrefs.HasKey (key)) {
			_highScore = PlayerPrefs.GetInt (key);
		}
	}

	private static Player _instance = null;

	public static Player Instance{

		get{ 
			if (_instance == null) {
				_instance = new Player ();
			}
			return _instance;
		}
	}

	public HUDController hud = null;

	private int _points = 0;
	private int _highScore = 0;
	private int _life = 3;

	public int Points {
		get {
			return _points;
		}set{ 
			_points = value;
			HighScore = _points;
			hud.UpdatePoints ();
		}
	}
 
	public int Life {
		get {
			return _life;
		}set{
			_life = value;
			hud.UpdateLife ();
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
				_highScore = value;
				PlayerPrefs.SetInt (key, _highScore);
			}
		}
	}
}
