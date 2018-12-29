//Imported Files
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//The PlayerAttacks Class
public class PlayerAttacks : MonoBehaviour {
	//Variables
	//This is stanard attack, so normal attack
	private int standardDamage;
	//This is like a crit hit
	private int mildDamage;
	//this is special ability damage
	private int specialDamage;
	//this is the PlayerDamage Method. used to defend what each damage output will be
	void PlayerDamage(){
		standardDamage = 2;
		mildDamage = 3;
		specialDamage = 10;
	}
	//Update method used for creating the connection between the button and the attack
	void Update(){
		if(Input.GetKey("s")){
			//this will be the standard attack.
			//damage output will be standardDamage.
			
		}
	}
}
