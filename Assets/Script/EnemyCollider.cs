using UnityEngine;
using System.Collections;

public class EnemyCollider : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag =="bullet"){
			Destroy(col.gameObject);
            this.gameObject.GetComponent<EnemyHealth> ().Health -= 20;
		}
	}
}
