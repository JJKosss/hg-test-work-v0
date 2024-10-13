using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public bool isGame = false;
	
	private float sensMouse = 600.0f;
	private float xMouse;
	private float yMouse;
	private float yRotateMouse = 10.0f;
	
	private float PosGun;
	
	public Camera camera;
	public GameObject GunObject;
	public CorouSpawn CorouSpawn;

	
	private float speed = 10.0f;
	private float hor;
	private float ver;
	
		
	private Rigidbody rigidPlayer;
	private float jump = 500;
	private bool forJump = true;
	
	 
	void Start()
    {
		
		rigidPlayer = GetComponent<Rigidbody>();
		camera.GetComponent<Camera>();
		Cursor.lockState = CursorLockMode.Locked;
		CorouSpawn = GameObject.Find("SpawnAndCorou").GetComponent<CorouSpawn>();
		
    }
	
	
	
    void Update()
    {
		
		if(CorouSpawn.isGameOver)
		{
			return;
		}
		
		
		xMouse = Input.GetAxis("Mouse X");
		yMouse = Input.GetAxis("Mouse Y");
		
	
		yRotateMouse -= yMouse;
		 
		
		
		camera.transform.localRotation = Quaternion.Euler(yRotateMouse, 0, 0);
		GunObject.transform.localRotation = Quaternion.Euler(yRotateMouse, 0, 0);
	
		
	
		
	
		transform.Rotate(Vector3.up * Time.deltaTime * sensMouse * xMouse);
	

		hor = Input.GetAxis("Horizontal");
		ver = Input.GetAxis("Vertical");
		
		transform.Translate(new Vector3(hor, 0, ver) * Time.deltaTime * speed);
		
		
		yRotateMouse = Mathf.Clamp(yRotateMouse, -90f, 90f);
		
		

		
		if(Input.GetKeyDown(KeyCode.Space) && forJump)
		{
			
			rigidPlayer.AddForce(Vector3.up * jump, ForceMode.Impulse);
			forJump = false;
		}	
		
		
		
		
	}
	
	
	private void OnCollisionEnter(Collision other)
	{
		
		forJump = true;
		
	}
	
	
	
}






