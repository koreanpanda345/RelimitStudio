using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttacks : MonoBehaviour {
	private int standardDamage;
	private int mildDamage;
	private int specialDamage;
	void PlayerDamage(){
		standardDamage = 2;
		mildDamage = 3;
		specialDamage = 10;
	}
	void Update(){
		if(Input.GetKey("s")){
			//this will be the standard attack.
			//damage output will be standardDamage.
			
		}
	}
}
