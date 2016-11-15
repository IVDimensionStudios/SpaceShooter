using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	private int damage = 100; 

	public int Damage{
		get{
			return damage; 
		}
	}

	public void Hit(){
		Destroy(gameObject); 
	}
}
