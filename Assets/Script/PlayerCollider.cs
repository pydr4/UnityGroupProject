using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag =="tanmu"){
			Destroy(col.gameObject);
		}
	}

}
