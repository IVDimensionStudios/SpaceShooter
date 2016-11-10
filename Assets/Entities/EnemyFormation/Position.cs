using UnityEngine;
using System.Collections;

public class Position : MonoBehaviour {

	void OnDrawGizmos()
	{
		Gizmos.DrawWireSphere(new Vector3(transform.position.x, transform.position.y), 1); 
	}

}
