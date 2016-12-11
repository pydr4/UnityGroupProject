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
public class EnemyCollider : MonoBehaviour {

	//detects if the bullet is hitting the enemy and subtracts 20 health
	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.tag =="bullet"){
			Destroy(col.gameObject);
            this.gameObject.GetComponent<EnemyHealth> ().Health -= 20;
		}
	}
}
