//Imported File
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//The Player Class
public class Player : MonoBehaviour {
	//This is the player max health.
	public int maxHealth;
	//This is the players current health
	private int health;
	//This will stay the same til the game restarts.
		void Awake(){
		SetDefault();
	}
	//The TakeDamage method will calcuate the damage output that player recieved by the enemy and applys it
	public void TakeDamage(int _amount){
		health -= _amount;

		Debug.Log(transform.name + "Now Has " + health + " health");
	}
	//The SetDefault method will change the current health everytime the player gets hit.
	public void SetDefault(){
		health = maxHealth;
	}
}
