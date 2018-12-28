using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	public int enemyMaxHealth;
	private int enemyHealth;
		void Awake(){
		SetDefault();
	}
	public void EnemyTakeDamage(int _amount){
		enemyHealth -= _amount;

		Debug.Log(transform.name + "Now Has " + enemyHealth + " health");
	}
	public void SetDefault(){
		enemyHealth = enemyMaxHealth;
	}
}
