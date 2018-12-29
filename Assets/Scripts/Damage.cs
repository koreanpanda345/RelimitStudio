//Imported File
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//The Damage Class
public class Damage : MonoBehaviour {
	//this is the minor enemy damage
	public int minorEnemyDamage;
	//this is mild enemy damage
	public int mildEnemyDamage;
	//this is the Major Enemy damage
	public int MajorEnemyDamage;
	//this is the Boss Enemy damage
	public int BossEnemyDamage;
	//The EnemyDamage method defines each enemys damage output, based on the standard attack.
	void EnemyDamage(){
		minorEnemyDamage = 3;
		mildEnemyDamage = 5;
		MajorEnemyDamage = 10;
		BossEnemyDamage = 20;
	}
}
