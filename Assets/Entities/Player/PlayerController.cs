using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 5.0f; 
	float newPosition; 
	float xmin;
	float xmax; 
	float padding = 0.5f; 

	// Use this for initialization
	void Start () {
		float distance = Camera.main.transform.position.z - transform.position.z;
		Vector3 leftMost = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, distance));
		Vector3 rightMost = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, distance));

		xmin = leftMost.x + padding;
		xmax = rightMost.x - padding; 
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position += new Vector3(-speed * Time.deltaTime, 0, 0); 
		}else if(Input.GetKey(KeyCode.RightArrow))
		{
			transform.position += new Vector3(speed * Time.deltaTime, 0, 0); 
		}

		newPosition = Mathf.Clamp(transform.position.x, xmin, xmax); 
		transform.position = new Vector3(newPosition, transform.position.y, 0); 
	}
}
