using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {
	public int minorEnemyDamage;
	public int mildEnemyDamage;
	public int MajorEnemyDamage;
	public int BossEnemyDamage;
	
	void EnemyDamage(){
		minorEnemyDamage = 3;
		mildEnemyDamage = 5;
		MajorEnemyDamage = 10;
		BossEnemyDamage = 20;
	}
}
