using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBalls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

       // Update is called once per frame
    void Update()
    {
        if( Input.GetMouseButtonDown(0)){
        	RaycastHit hit;
        	Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        	if(Physics.Raycast(ray, out hit))
        	{
        		
        		SphereCollider  Sc = hit.collider as SphereCollider;
        		if(Sc!= null)
        		{
        			Destroy(Sc.gameObject);

        		}

        	}
        }
    }
}