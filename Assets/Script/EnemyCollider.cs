using UnityEngine;
using System.Collections;

public class EnemyCollider : MonoBehaviour {
	[SerializeField]
	private int points = 0;
	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag =="bullet"){
			Destroy(col.gameObject);
			Player.Instance.Points += points;
            this.gameObject.GetComponent<EnemyHealth> ().Health -= 20;
		}
	}
}
