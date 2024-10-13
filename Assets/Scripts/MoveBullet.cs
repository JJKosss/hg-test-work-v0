using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    
	public float bulletspeed = 100f;
	
	
    void Update()
    {
        
		transform.Translate(Vector3.forward * Time.deltaTime * bulletspeed);
		
		
		if(transform.position.x > 40)
			Destroy(gameObject);
		if(transform.position.x < -40)
			Destroy(gameObject);
		
		if(transform.position.y < 1f)
			Destroy(gameObject);
		if(transform.position.y > 30f)
			Destroy(gameObject);
		
		
		
		if(transform.position.z > 50)
			Destroy(gameObject);
		if(transform.position.z < -50)
			Destroy(gameObject);
		
		
    }
	
	
	
	
	
}
