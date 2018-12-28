using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttacks : MonoBehaviour {
	private float standardDamage;
	private float mildDamage;
	private float specialDamage;
	void Start(){
		standardDamage = 2f;
		mildDamage = 3f;
		specialDamage = 10f;
	}
}
