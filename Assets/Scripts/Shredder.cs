using UnityEngine;
using System.Collections;

public class Shredder : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collider)
	{
		Debug.Log("Trigger has occured");
		Destroy(collider.gameObject); 
	}
}
