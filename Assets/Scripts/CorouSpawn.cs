using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorouSpawn : MonoBehaviour
{
	
	public bool isGameOver = false;
	
	public bool isActive = true;
	
	private float TimeSpawnCorouOne = 3.5f;
	private float TimeSpawnCorouTwo = 3.5f;
	
	public GameObject enemyPrefabOnePlane;
	
	public GameObject enemyPrefabTwoPlane;
	
	
	private Coroutine CoroutineOne;
	private Coroutine CoroutineTwo;
	public List<GameObject> EnemyOneSpawn = new List<GameObject>();
	private GameObject Canvas;
	private GameObject Player;
	
	
	
	private void OnTriggerEnter(Collider collider)
	{
		if(collider.gameObject.CompareTag("zoneTrueFalse"))
		{
			isActive =! isActive;
		}
		else if(collider.gameObject.CompareTag("Ground"))
		{
			
			
			StopCoroutine(CoroutineOne);
			Canvas.transform.GetChild(1).gameObject.SetActive(true);
			Canvas.transform.GetChild(2).gameObject.SetActive(true);
			Canvas.transform.GetChild(3).gameObject.SetActive(true);
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
			isGameOver = true;
			
			
			
		}
		
		else if(collider.gameObject.CompareTag("GroundThree"))
		{
			StopCoroutine(CoroutineOne);
			Player = GameObject.Find("Player Object");
		}
	}
	
	
	
	
	
	public void Start()
	{
		
		CoroutineOne = StartCoroutine(StartCoroutineOne());
		Canvas = GameObject.Find("Canvas");
		
		
	}
	
	
	IEnumerator StartCoroutineOne()
	{
		while(true)
		{
			if(isActive)
			{
				Vector3 randomOne = new Vector3(Random.Range(-10, 10), 3, Random.Range(-10, 10));
				yield return new WaitForSeconds(TimeSpawnCorouOne);
				Instantiate(enemyPrefabOnePlane, randomOne, transform.rotation);
				
				EnemyOneSpawn.Add(enemyPrefabOnePlane); 
			}
			
			if(!isActive)
			{
				
				yield return new WaitForSeconds(TimeSpawnCorouTwo);
				CoroutineTwo = StartCoroutine(StartCoroutineTwo());
				
			}
				yield return null;
			
		}
		
	}
	
	IEnumerator StartCoroutineTwo()
	{
		if(!isActive)
		{
			Vector3 randomTwo = new Vector3(Random.Range(-54, -30), 5.6f, Random.Range(-5, 16));
			Instantiate(enemyPrefabTwoPlane, randomTwo, transform.rotation); 
			
		}
			yield return null;	
	}
	
	

	
	
 
}
