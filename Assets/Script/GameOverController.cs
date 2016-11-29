using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour {


	[SerializeField]
	private Text scorelbl = null;

	[SerializeField]
	private Text highScorelbl = null;

	// Use this for initialization
	void Start () {
		scorelbl.text = "Score: " + Player.Instance.Points;
		highScorelbl.text = "All Time Best: " + Player.Instance.HighScore;
	}

	public void OpenNewGame(){
		SceneManager.LoadScene (0);
	}

}
