using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartGame : MonoBehaviour
{
	
	
	private Button button;
	
	void Start()
	{
		
		button = GetComponent<Button>();
		button.onClick.AddListener(gameRestarting);
		
	}
    
	
	
	void gameRestarting()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
	
	
}
