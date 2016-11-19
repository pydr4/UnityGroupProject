using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

	public void NewGame(){
		SceneManager.LoadScene (1);
	}

}
