using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {
	public float minorEnemyDamage;
	public float mildEnemyDamage;
	public float MajorEnemyDamage;
	public float BossEnemyDamage;
	
	void Start(){
		minorEnemyDamage = 3f;
		mildEnemyDamage = 5f;
		MajorEnemyDamage = 10f;
		BossEnemyDamage = 20f;
	}
}
