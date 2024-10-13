using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public bool gameActive = true;
	
	private CorouSpawn Spawn;
	private PlayerController player;
	private GameObject panel;
	private GameObject CanvasImageSight;
	
	private Button button;
	
	
	void Start()
	{
		
		Spawn = GameObject.Find("SpawnAndCorou").GetComponent<CorouSpawn>();
		player = GameObject.Find("Player Object").GetComponent<PlayerController>();
		panel = GameObject.Find("Canvas");
		CanvasImageSight = GameObject.Find("CanvasImageSight");
		
		
		button = GetComponent<Button>();
		button.onClick.AddListener(StartScriptSpawn);
	}
	
	void StartScriptSpawn()
	{
	
		
		
		panel.SetActive(false);
		CanvasImageSight.transform.GetChild(0).gameObject.SetActive(true);
		
	}
	
	

	
	
    
}
