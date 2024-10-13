using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{   
	private Rigidbody enemyObject;
	private GameObject player;
	public float speedEnemy = 200f;
	
	private CorouSpawn CorouSpawn;
	
	
	
	void Start()
	{
		enemyObject = GetComponent<Rigidbody>();
		player = GameObject.Find("Player Object");
		CorouSpawn = GameObject.Find("SpawnAndCorou").GetComponent<CorouSpawn>();
	}
	
	
	void Update()
	{
	
		enemyObject.AddForce((player.transform.position - transform.position).normalized * speedEnemy);
		
		if(CorouSpawn.isGameOver)
		{
			Destroy(gameObject);  
		}
		
		if(transform.position.x > 15)
			Destroy(gameObject);
		if(transform.position.x < -13)
			Destroy(gameObject);
		
		if(transform.position.z > 15)
			Destroy(gameObject);
		if(transform.position.z < -15)
			Destroy(gameObject);
		
	}
	
	
	
}
