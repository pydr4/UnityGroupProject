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
public class PlayerCollider : MonoBehaviour {

	//renderer to control the blinking
	Renderer rd = null;
	//see if the player needs blinking
	bool normal = true;
	void Start(){
		rd = gameObject.GetComponent<Renderer> ();
	}



	void OnTriggerEnter2D(Collider2D col){
		normal = true;
		if(col.gameObject.tag =="tanmu"){
			//if enemy bullet hits player player blinks and turns off the collider
			//for 2 seconds
			//1 life is lost during that process
			gameObject.GetComponent<CircleCollider2D> ().enabled = false;
			Invoke ("setEnable", 2f);
			InvokeRepeating ("Blink", 0f, 0.2f);
			Player.Instance.Life--;
			Destroy(col.gameObject);
		}
	}

	//blinks player indicating its being hit
	void Blink(){
		normal = !normal;
		if (normal) {
			rd.material.color = Color.clear;

		}else
		rd.material.color = Color.yellow;
	}


	//turns enables player collider
	void setEnable(){
		gameObject.GetComponent<CircleCollider2D> ().enabled = true;
		rd.material.color = Color.yellow;
		CancelInvoke ();
	}

}
