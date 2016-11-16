using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	public GameObject enemyLaser; 
	private int health = 150 ; 
	public float speed = 2.0f; 
	public float frequency = 0.5f; 

	void OnTriggerEnter2D(Collider2D collider)
	{
		Debug.Log("Trigger has occured b/w enemy & laser"); 
		Projectile missile = collider.gameObject.GetComponent<Projectile>(); 

		if(missile){
			health -= missile.Damage; 
			missile.Hit(); 
			if(health <= 0){
				Destroy(gameObject); 
			}
		}
	}

	void Update(){
		

		float probabilityOfShooting = Time.deltaTime * frequency ;// Probabability(Of Shooting) = TimeElapsed * Frequency
			
		if(Random.value < probabilityOfShooting){
			Fire(); 
		}
	}

	void Fire()
	{
		Vector3 offset = new Vector3(0, -1f, 0); 
		GameObject enemyLsr = Instantiate(enemyLaser, transform.position + offset, Quaternion.identity) as GameObject;
		enemyLsr.GetComponent<Rigidbody2D>().velocity = new Vector3(0, -speed, 0);
	}
}
