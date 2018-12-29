//Imported File
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//The Enemy Class
public class Enemy : MonoBehaviour {
	//this is the Enemy Health at max
	public int enemyMaxHealth;
	//This is the enemy current health
	private int enemyHealth;
	//Awake Method is going to keep the same statics, till game is restarted
		void Awake(){
		SetDefault();
	}
	//this is the enemy damage taken. when the player attacks the enemy this will calcuate the damage output. then applys it.
	public void EnemyTakeDamage(int _amount){
		enemyHealth -= _amount;

		Debug.Log(transform.name + "Now Has " + enemyHealth + " health");
	}
	//the SetDefault method will change the enemy health everytime the enemy gets hit.
	public void SetDefault(){
		enemyHealth = enemyMaxHealth;
	}
}
