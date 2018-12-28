using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public int maxHealth;
	private int health;
		void Awake(){
		SetDefault();
	}
	public void TakeDamage(int _amount){
		health -= _amount;

		Debug.Log(transform.name + "Now Has " + health + " health");
	}
	public void SetDefault(){
		health = maxHealth;
	}
}
