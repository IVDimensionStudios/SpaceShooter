using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	public GameObject enemyPrefab; 
	public float width = 15f; 
	public float height = 10f; 
	public float speed = 5f; 
	public bool rightTouched = false; 
	public float padding = 15.0f; 

	public float xxxMax = 5f;
	public float xxxMin = -9f; 

	// Use this for initialization
	void Start () {
		float distance = Camera.main.transform.position.z - transform.position.z;
		Vector3 leftBoundary = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance));
		Vector3 rightBoundary = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, distance));

		xxxMax = rightBoundary.x - padding; 
		xxxMin = leftBoundary.x + padding; 

		foreach(Transform child in transform)
		{
			GameObject enemy = Instantiate(enemyPrefab, child.position, Quaternion.identity) as GameObject; 
			enemy.transform.parent = child;
		}
	}

	void OnDrawGizmos()
	{
		Gizmos.DrawWireCube(new Vector3(0,0,0), new Vector3(width, height));
	}


	// Update is called once per frame
	void Update () {
		 
		if(transform.position.x < xxxMax && rightTouched){
			transform.position += new Vector3(speed * Time.deltaTime, 0, 0); 
			rightTouched = true; 
		}else if(transform.position.x > xxxMin){
			transform.position += new Vector3(-speed * Time.deltaTime, 0, 0); 
			rightTouched = false; 
		}


	}
}
