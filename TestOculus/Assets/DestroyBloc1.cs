using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBloc1 : MonoBehaviour
{
public int nb = 0;
//public int currentTexture;
//Renderer m_color;
public Material[] materials;
public Renderer rend;

private int index = 2;

    // Start is called before the first frame update
    void Start()
    {
        rend=GetComponent<Renderer>();
        rend.enabled = true;        
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        if(materials.Length==0){
            return;
        }

        if( Input.GetMouseButtonDown(0)){
        	RaycastHit hit;
        	Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        	if(Physics.Raycast(ray, out hit))
        	{
        		BoxCollider bc = hit.collider as BoxCollider;
        		
        		if(bc!= null)
        		{	

        			if (index<= materials.Length){
                        print(index);

                        rend.sharedMaterial = materials[index-1];
        			}
                                
                    if (index >= materials.Length+1 || materials.Length==1)
                    {
                        Destroy(bc.gameObject);                       
                    }
                    index += 1;
        			nb++;

        		}
                /*
        		SphereCollider  Sc = hit.collider as SphereCollider;
        		if(Sc!= null)
        		{
        			Destroy(Sc.gameObject);

        		}
                if(Input.GetKeyDown(KeyCode.Space)){
                        currentTexture++;
                        currentTexture%=textures.Length;

                      //  GetComponent<Renderer>().material.mainMaterial = textures[currentTexture];
                        //GetComponent<renderer>().material.mainMaterial = textures[currentTexture];
                }*/
        	}
        }
    }
}
