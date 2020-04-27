using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Addnewblock : MonoBehaviour
{
	public GameObject ball;
    // Start is called before the first frame update
    public void  createcube()
    {
    	Instantiate(ball, new Vector3(2,3,0), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
