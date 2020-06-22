using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportV2 : MonoBehaviour
{
    public float x=39.5f, y=0.0f, z = 39.5f; //Dimension de la scène
  
   void OnCollisionEnter(Collision col)
    {
        if (this.name == "TeleporteurAleatoire")
        {
            Vector3 destination = new Vector3(Random.value * x - x / 2, 0.2f, Random.value * z - z / 2);
            col.transform.position = destination;
        }
        if (this.name == "TeleporteurFixe")
        {
            Vector3 destination = new Vector3(0, 0.2f, 0);
            col.transform.position = destination;
        }

        if (this.name == "TeleporteurRelatif")
        {   
            Vector3 destination = new Vector3(col.transform.position.x-5, 0.2f, col.transform.position.z+10);

            //Verification que la destination est bien dans la scène
            if (destination.x > x / 2) destination.x = (x/2 -1);
            if (destination.x < -x / 2) destination.x = (-x/2 +1);
            if (destination.z > z / 2) destination.z = (z/2 -1);
            if (destination.z < -z / 2) destination.z = (-z/2 +1);
            col.transform.position = destination;
        }
    }
}