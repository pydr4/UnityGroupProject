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
public class StartGame : MonoBehaviour {
	// adds sound to button on startgame and loads scene

	public void NewGame(){
		//gets the button sound
		AudioSource button = gameObject.GetComponent<AudioSource> ();
		if (button != null)
			button.Play ();

		//loads scene after 0.2s to allow sound to be played
		Invoke ("LoadScene", 0.2f);

	}

	void LoadScene(){
	
		SceneManager.LoadScene (1);
	}


}
