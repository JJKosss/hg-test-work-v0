using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTwo : MonoBehaviour
{
    private float speedEnemy = 200f;
	private GameObject Player;
	private Rigidbody enemyObject;
	
	
	void Start()
	{
		Player = GameObject.Find("Player Object");
		enemyObject = GetComponent<Rigidbody>();
	} 
	
	
	void Update()
	{
		
		enemyObject.AddForce((Player.transform.position - transform.position).normalized * speedEnemy);
		
	}
	
}
