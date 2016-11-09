﻿using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	public GameObject enemyPrefab; 

	// Use this for initialization
	void Start () {
		GameObject enemy = Instantiate(enemyPrefab, transform.position, Quaternion.identity) as GameObject; 
		enemy.transform.parent = this.transform; 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}