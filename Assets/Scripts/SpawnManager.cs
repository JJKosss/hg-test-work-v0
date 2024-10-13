using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
	
	
    public GameObject bulletObject;
	
	public LayerMask layer; 
	
	private float speedHit = 100f; 
	
	
    void Update()
    {
		
		if(Input.GetMouseButtonDown(0))
		{
			if(Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, 100f, layer))
			{
				
				if(hit.collider)
				{
					Destroy(hit.collider.gameObject);
					
				}
				
			}
		}
        
    }
}
