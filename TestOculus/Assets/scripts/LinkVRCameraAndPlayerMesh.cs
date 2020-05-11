using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkVRCameraAndPlayerMesh : MonoBehaviour
{
    public Vector3 playeVRPosition;
    public Vector3 playeVRRotation;

    // Start is called before the first frame update
    void Start()
    {
        
        this.playeVRPosition  =  GameObject.FindGameObjectWithTag("Player").transform.position;
        //this.playeVRPosition  =  GameObject.FindGameObjectWithTag("Player").transform.rotation;
        Debug.Log(playeVRPosition);
        //Debug.Log(playeVRRotation);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
