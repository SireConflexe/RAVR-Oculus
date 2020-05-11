using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public float x=39.5f, y=0.0f, z = 39.5f;
  
   void OnCollisionEnter(Collision col)
    {
        Vector3 destination = new Vector3(Random.value*x-x/2, 0.2f, Random.value*z-z/2);
        if (this.name == "Teleporteur")
        {
            col.transform.position = destination;
        }
    }
}
